data_a1e2fb4a_e986_4524_b0da_9b7ba7c0874d = 
{
	"main": {
		"floorIds": [
			"sample0",
			"sample1",
			"sample2",
			"sample3",
			"MT0",
			"a",
			"b",
			"c",
			"d",
			"e"
		],
		"images": [
			"bg.jpg"
		],
		"tilesets": [],
		"animates": [
			"hand",
			"sword",
			"zone"
		],
		"bgms": [
			"bgm.mp3",
			"bgm2.mp3"
		],
		"sounds": [
			"floor.mp3",
			"attack.mp3",
			"door.mp3",
			"item.mp3",
			"equip.mp3",
			"zone.mp3",
			"jump.mp3"
		],
		"startBackground": "bg.jpg",
		"startLogoStyle": "color: black",
		"levelChoose": [
			[
				"现实",
				"Hell"
			]
		],
		"equipName": [
			"武器",
			"盾牌"
		],
		"statusLeftBackground": "url(project/images/ground.png) repeat",
		"statusTopBackground": "url(project/images/ground.png) repeat",
		"toolsBackground": "url(project/images/ground.png) repeat",
		"borderColor": "white"
	},
	"firstData": {
		"title": "wcpzzz的人生",
		"name": "wcpzzz",
		"version": "Ver 2.4.3",
		"floorId": "a",
		"hero": {
			"name": "wcpzzz",
			"lv": 1,
			"hpmax": 9999,
			"hp": 1000,
			"atk": 100,
			"def": 100,
			"mdef": 100,
			"money": 100,
			"experience": 0,
			"equipment": [],
			"items": {
				"keys": {
					"yellowKey": 0,
					"blueKey": 0,
					"redKey": 0
				},
				"constants": {},
				"tools": {},
				"equips": {}
			},
			"flyRange": [],
			"loc": {
				"direction": "up",
				"x": 6,
				"y": 10
			},
			"flags": {},
			"steps": 0
		},
		"startText": [
			"1997年5月，wcpzzz出生了。\n\n2003年9月，就读于上海市罗南中心小学，年级共约180人。",
			"初生牛犊不怕虎，熊孩子wcpzzz自此度过了一段得意洋洋、任行天地的时光。",
			"曾不做作业被留到晚上7点，也曾因成绩优秀当上了学委\n\n但一切都如幼儿园满墙小红花一样，也就图个追忆时的念想。",
			"谨以此层，回忆小学时代"
		],
		"shops": [
			{
				"id": "moneyShop1",
				"name": "贪婪之神",
				"icon": "blueShop",
				"textInList": "1F金币商店",
				"use": "money",
				"need": "20+10*times*(times+1)",
				"text": "勇敢的武士啊，给我${need}金币就可以：",
				"choices": [
					{
						"text": "生命+800",
						"effect": "status:hp+=800"
					},
					{
						"text": "攻击+4",
						"effect": "status:atk+=4"
					},
					{
						"text": "防御+4",
						"effect": "status:def+=4"
					},
					{
						"text": "魔防+10",
						"effect": "status:mdef+=10"
					}
				]
			},
			{
				"id": "expShop1",
				"name": "经验之神",
				"icon": "pinkShop",
				"textInList": "1F经验商店",
				"use": "experience",
				"need": "-1",
				"text": "勇敢的武士啊，给我若干经验就可以：",
				"choices": [
					{
						"text": "等级+1",
						"need": "100",
						"effect": "status:lv+=1;status:hp+=1000;status:atk+=7;status:def+=7"
					},
					{
						"text": "攻击+5",
						"need": "30",
						"effect": "status:atk+=5"
					},
					{
						"text": "防御+5",
						"need": "30",
						"effect": "status:def+=5"
					}
				]
			}
		],
		"levelUp": [
			{},
			{
				"need": 20,
				"name": "第二级",
				"effect": "status:hp+=2*(status:atk+status:def);status:atk+=10;status:def+=10"
			},
			{
				"need": 40,
				"effect": "function () {\r\n\t\t\tcore.insertAction(\"恭喜升级！\");\r\n\t\t\tcore.status.hero.hp *= 2;\r\n\t\t\tcore.status.hero.atk += 100;\r\n\t\t\tcore.status.hero.def += 100;\r\n\t\t}"
			}
		]
	},
	"values": {
		"lavaDamage": 100,
		"poisonDamage": 10,
		"weakValue": 20,
		"redJewel": 3,
		"blueJewel": 3,
		"greenJewel": 5,
		"redPotion": 100,
		"bluePotion": 250,
		"yellowPotion": 500,
		"greenPotion": 800,
		"moneyPocket": 500,
		"breakArmor": 0.9,
		"counterAttack": 0.1,
		"purify": 3,
		"hatred": 2,
		"maxValidHp": null,
		"animateSpeed": 300
	},
	"flags": {
		"enableFloor": true,
		"enableName": false,
		"enableLv": false,
		"enableHPMax": false,
		"enableMDef": true,
		"enableMoney": true,
		"enableExperience": false,
		"enableLevelUp": false,
		"enableKeys": true,
		"enablePZF": false,
		"enableDebuff": false,
		"flyNearStair": true,
		"pickaxeFourDirections": false,
		"bombFourDirections": false,
		"snowFourDirections": false,
		"bigKeyIsBox": false,
		"equipment": false,
		"equipboxButton": false,
		"equipPercentage": false,
		"enableAddPoint": false,
		"enableNegativeDamage": false,
		"hatredDecrease": true,
		"betweenAttackCeil": false,
		"useLoop": false,
		"startDirectly": false,
		"canOpenBattleAnimate": true,
		"showBattleAnimateConfirm": false,
		"battleAnimate": false,
		"displayEnemyDamage": true,
		"displayCritical": true,
		"displayExtraDamage": true,
		"enableGentleClick": true,
		"potionWhileRouting": false,
		"enableViewMaps": false,
		"portalWithoutTrigger": false,
		"canGoDeadZone": false,
		"enableMoveDirectly": false,
		"clickMoveDirectly": false
	}
}