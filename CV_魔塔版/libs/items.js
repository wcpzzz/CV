function items() {
    this.init();
}

////// 初始化 //////
items.prototype.init = function () {
    this.items = items_296f5d02_12fd_4166_a7c1_b5e830c9ee3a.items;
    this.itemEffect = items_296f5d02_12fd_4166_a7c1_b5e830c9ee3a.itemEffect;
    this.itemEffectTip = items_296f5d02_12fd_4166_a7c1_b5e830c9ee3a.itemEffectTip;
    this.useItemEffect = items_296f5d02_12fd_4166_a7c1_b5e830c9ee3a.useItemEffect;
    this.canUseItemEffect = items_296f5d02_12fd_4166_a7c1_b5e830c9ee3a.canUseItemEffect;
    //delete(items_296f5d02_12fd_4166_a7c1_b5e830c9ee3a);
}

////// 获得所有道具 //////
items.prototype.getItems = function () {
    return this.items;
}

////// “即捡即用类”道具的使用效果 //////
items.prototype.getItemEffect = function(itemId, itemNum) {
    var itemCls = core.material.items[itemId].cls;
    // 消耗品
    if (itemCls === 'items') {
        var ratio = parseInt(core.status.thisMap.item_ratio) || 1;
        var curr_hp = core.status.hero.hp;
        if (itemId in this.itemEffect)eval(this.itemEffect[itemId]);
        core.status.hero.statistics.hp += core.status.hero.hp - curr_hp;
    }
    else {
        core.addItem(itemId, itemNum);
    }
}

////// “即捡即用类”道具的文字提示 //////
items.prototype.getItemEffectTip = function(itemId) {
    var itemCls = core.material.items[itemId].cls;
    // 消耗品
    if (itemCls === 'items') {
        var ratio = parseInt(core.status.thisMap.item_ratio) || 1;
        if (itemId in this.itemEffectTip) return eval(this.itemEffectTip[itemId])||"";
    }
    return "";
}

////// 使用道具 //////
items.prototype.useItem = function (itemId, callback) {
    if (!this.canUseItem(itemId)) {
        if (core.isset(callback)) callback();
        return;
    }
    var itemCls = core.material.items[itemId].cls;

    if (itemId in this.useItemEffect) {
        eval(this.useItemEffect[itemId]);
    }
    // 记录路线
    if (itemId!='book' && itemId!='fly') {
        core.status.route.push("item:"+itemId);
    }

    // 道具使用完毕：删除
    if (itemCls=='tools')
        core.status.hero.items[itemCls][itemId]--;
    if (core.status.hero.items[itemCls][itemId]==0)
        delete core.status.hero.items[itemCls][itemId];

    core.updateStatusBar();

    if (core.isset(callback)) callback();
}

////// 当前能否使用道具 //////
items.prototype.canUseItem = function (itemId) {
    // 没有道具
    if (!core.hasItem(itemId)) return false;

    if (itemId in this.canUseItemEffect) {
        return eval(this.canUseItemEffect[itemId]);
    }

    return false;
}

////// 获得某个物品的个数 //////
items.prototype.itemCount = function (itemId) {
    if (!core.isset(itemId) || !core.isset(core.material.items[itemId])) return 0;
    var itemCls = core.material.items[itemId].cls;
    if (itemCls=="items") return 0;
    return core.isset(core.status.hero.items[itemCls][itemId]) ? core.status.hero.items[itemCls][itemId] : 0;
}

////// 是否存在某个物品 //////
items.prototype.hasItem = function (itemId) {
    return core.itemCount(itemId) > 0;
}

////// 是否装备某件装备 //////
items.prototype.hasEquip = function (itemId) {

    if (!core.isset(itemId)) return null;
    if (!core.isset((core.material.items[itemId]||{}).equip)) return null;

    return itemId == this.getEquip(core.material.items[itemId].equip.type);
}

////// 获得某个装备类型的当前装备 //////
items.prototype.getEquip = function (equipType) {
    return (core.status.hero.equipment||[])[equipType]||null;
}

////// 设置某个物品的个数 //////
items.prototype.setItem = function (itemId, itemNum) {
    itemNum = itemNum || 0;
    if (itemNum<=0) itemNum = 0;
    var itemCls = core.material.items[itemId].cls;
    if (itemCls == 'items') return;
    if (!core.isset(core.status.hero.items[itemCls])) {
        core.status.hero.items[itemCls] = {};
    }
    core.status.hero.items[itemCls][itemId] = itemNum;
    if (itemCls!='keys' && itemNum==0) {
        delete core.status.hero.items[itemCls][itemId];
    }
}

////// 删除某个物品 //////
items.prototype.removeItem = function (itemId, itemNum) {
    itemNum = itemNum || 1;
    if (!core.hasItem(itemId)) return false;
    var itemCls = core.material.items[itemId].cls;
    core.status.hero.items[itemCls][itemId]-=itemNum;
    if (itemCls!='keys' && core.status.hero.items[itemCls][itemId]<=0) {
        delete core.status.hero.items[itemCls][itemId];
    }
    core.updateStatusBar();
    return true;
}

////// 增加某个物品的个数 //////
items.prototype.addItem = function (itemId, itemNum) {
    itemNum=itemNum||1;
    var itemData = core.material.items[itemId];
    var itemCls = itemData.cls;
    if (itemCls == 'items') return;
    if (!core.isset(core.status.hero.items[itemCls])) {
        core.status.hero.items[itemCls] = {};
        core.status.hero.items[itemCls][itemId] = 0;
    }
    else if (!core.isset(core.status.hero.items[itemCls][itemId])) {
        core.status.hero.items[itemCls][itemId] = 0;
    }
    core.status.hero.items[itemCls][itemId] += itemNum;
    // 永久道具只能有一个
    if (itemCls == 'constants' && core.status.hero.items[itemCls][itemId]>1)
        core.status.hero.items[itemCls][itemId] = 1;
}


////// 换上 //////
items.prototype.loadEquip = function (equipId, callback) {

    if (!core.isset(core.status.hero.equipment)) core.status.hero.equipment = [];

    core.playSound('equip.mp3');

    var loadEquip = core.material.items[equipId];
    if (!core.isset(loadEquip)) {
        if (core.isset(callback)) callback();
        return;
    }
    var loadEquipType = loadEquip.equip.type;
    var unloadEquipId = core.status.hero.equipment[loadEquipType];

    // 比较能力值
    var result = core.compareEquipment(equipId,unloadEquipId);

    if (core.flags.equipPercentage) {
        core.setFlag('equip_atk_buff', core.getFlag('equip_atk_buff',1)+result.atk/100);
        core.setFlag('equip_def_buff', core.getFlag('equip_def_buff',1)+result.def/100);
        core.setFlag('equip_mdef_buff', core.getFlag('equip_mdef_buff',1)+result.mdef/100);
    }
    else {
        core.status.hero.atk += result.atk;
        core.status.hero.def += result.def;
        core.status.hero.mdef += result.mdef;
    }

    // 更新装备状态
    core.status.hero.equipment[loadEquipType] = equipId;
    core.updateStatusBar();

    // 记录路线
    // core.status.route.push("equip:"+equipId);

    // 装备更换完毕：删除换上的装备
    core.removeItem(equipId);
    
    // 装备更换完毕：增加卸下的装备
    if (core.isset(unloadEquipId))
        core.addItem(unloadEquipId, 1);

    core.drawTip("已装备上"+loadEquip.name, core.material.icons.items[equipId]);

    if (core.isset(callback)) callback();
}

////// 卸下 //////
items.prototype.unloadEquip = function (equipType, callback) {

    if (!core.isset(core.status.hero.equipment)) core.status.hero.equipment = [];

    core.playSound('equip.mp3');

    var unloadEquipId = core.status.hero.equipment[equipType];
    if (!core.isset(unloadEquipId)) {
        if (core.isset(callback)) callback();
        return;
    }
    var unloadEquip = core.material.items[unloadEquipId];

    // 处理能力值改变
    if (core.flags.equipPercentage) {
        core.setFlag('equip_atk_buff', core.getFlag('equip_atk_buff',1)-(unloadEquip.equip.atk||0)/100);
        core.setFlag('equip_def_buff', core.getFlag('equip_def_buff',1)-(unloadEquip.equip.def||0)/100);
        core.setFlag('equip_mdef_buff', core.getFlag('equip_mdef_buff',1)-(unloadEquip.equip.mdef||0)/100);
    }
    else {
        core.status.hero.atk -= unloadEquip.equip.atk || 0;
        core.status.hero.def -= unloadEquip.equip.def || 0;
        core.status.hero.mdef -= unloadEquip.equip.mdef || 0;
    }

    // 更新装备状态
    core.status.hero.equipment[equipType] = null;

    core.updateStatusBar();

    // 记录路线
    // core.status.route.push("unEquip:"+equipType);
    
    // 装备更换完毕：增加卸下的装备
    core.addItem(unloadEquipId, 1);

    core.drawTip("已卸下"+unloadEquip.name, core.material.icons.items[unloadEquipId]);

    if (core.isset(callback)) callback();
}

items.prototype.compareEquipment = function (compareEquipId, beComparedEquipId) {
    var compareAtk = 0, compareDef = 0, compareMdef = 0;
    if (core.isset(compareEquipId)) {
        var compareEquip = core.material.items[compareEquipId];
        compareAtk += (compareEquip.equip||{}).atk || 0;
        compareDef += (compareEquip.equip||{}).def || 0;
        compareMdef += (compareEquip.equip||{}).mdef || 0;
    }
    if (core.isset(beComparedEquipId)) {
        var beComparedEquip = core.material.items[beComparedEquipId];
        compareAtk -= (beComparedEquip.equip||{}).atk || 0;
        compareDef -= (beComparedEquip.equip||{}).def || 0;
        compareMdef -= (beComparedEquip.equip||{}).mdef || 0;
    }
    return {"atk":compareAtk,"def":compareDef,"mdef":compareMdef};
}