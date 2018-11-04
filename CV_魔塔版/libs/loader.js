/*
loader.js：负责对资源的加载

 */

function loader() {
    this.init();
}

loader.prototype.init = function () {

}

////// 设置加载进度条进度 //////
loader.prototype.setStartProgressVal = function (val) {
    core.dom.startTopProgress.style.width = val + '%';
}

////// 设置加载进度条提示文字 //////
loader.prototype.setStartLoadTipText = function (text) {
    core.dom.startTopLoadTips.innerHTML = text;
}

loader.prototype.load = function (callback) {

    // 加载icons
    core.loader.loadIcons();

    // 加载图片
    core.loader.loadImages(core.materials, core.material.images, function () {
        // 加载png图片
        core.material.images.images = {};

        var images = core.clone(core.images);
        if (images.indexOf("hero.png")<0)
            images.push("hero.png");

        core.loader.loadImages(images, core.material.images.images, function () {
            // 加载autotile
            core.material.images.autotile = {};
            core.loader.loadImages(Object.keys(core.material.icons.autotile), core.material.images.autotile, function () {

                // 加载tilesets
                core.material.images.tilesets = {};
                if (!core.isset(core.tilesets)) core.tilesets = [];
                core.loader.loadImages(core.clone(core.tilesets), core.material.images.tilesets, function () {

                    // 检查宽高是32倍数，如果出错在控制台报错
                    for (var imgName in core.material.images.tilesets) {
                        var img = core.material.images.tilesets[imgName];
                        if (img.width%32!=0 || img.height%32!=0) {
                            console.warn("警告！"+imgName+"的宽或高不是32的倍数！");
                        }
                        if (img.width * img.height > 32*32*1000) {
                            console.warn("警告！"+imgName+"上的图块素材个数大于1000！");
                        }
                    }

                    core.loader.loadAnimates();
                    core.loader.loadMusic();
                    if (core.isset(callback))
                        callback();
                })
            })
        })
    })
}

loader.prototype.loadIcons = function () {

    this.loadImage("icons.png", function (id, image) {
        var images = core.cropImage(image);
        for (var key in core.statusBar.icons) {
            if (typeof core.statusBar.icons[key] == 'number') {
                core.statusBar.icons[key] = images[core.statusBar.icons[key]];
                if (core.isset(core.statusBar.image[key]))
                    core.statusBar.image[key].src = core.statusBar.icons[key].src;
            }
        }
    });
}

loader.prototype.loadImages = function (names, toSave, callback) {
    if (!core.isset(names) || names.length==0) {
        if (core.isset(callback)) callback();
        return;
    }
    var items = 0;
    for (var i=0;i<names.length;i++) {
        this.loadImage(names[i], function (id, image) {
            core.loader.setStartLoadTipText('正在加载图片 ' + id + "...");
            toSave[id] = image;
            items++;
            core.loader.setStartProgressVal(items * (100 / names.length));
            if (items == names.length) {
                if (core.isset(callback)) callback();
            }
        })
    }
}

loader.prototype.loadImage = function (imgName, callback) {
    try {
        var name=imgName;
        if (name.indexOf(".")<0)
            name=name+".png";
        var image = new Image();
        image.src = 'project/images/' + name + "?v=" + main.version;
        if (image.complete) {
            callback(imgName, image);
            return;
        }
        image.onload = function () {
            callback(imgName, image);
        }
    }
    catch (e) {
        console.log(e);
    }
}

loader.prototype.loadAnimates = function () {
    core.animates.forEach(function (t) {
        core.http('GET', 'project/animates/' + t + ".animate", null, function (content) {
            try {
                content = JSON.parse(content);
                var data = {};
                data.ratio = content.ratio;
                data.se = content.se;
                data.images = [];
                data.images_rev = [];
                content.bitmaps.forEach(function (t2) {
                    if (!core.isset(t2) || t2 == "") {
                        data.images.push(null);
                    }
                    else {
                        try {
                            var image = new Image();
                            image.src = t2;
                            data.images.push(image);
                        } catch (e) {
                            data.images.push(null);
                        }
                    }
                })
                data.frame = content.frame_max;
                data.frames = [];
                content.frames.forEach(function (t2) {
                    var info = [];
                    t2.forEach(function (t3) {
                        info.push({
                            'index': t3[0],
                            'x': t3[1],
                            'y': t3[2],
                            'zoom': t3[3],
                            'opacity': t3[4],
                            'mirror': t3[5] || 0,
                            'angle': t3[6] || 0,
                        })
                    })
                    data.frames.push(info);
                })
                core.material.animates[t] = data;
            }
            catch (e) {
                console.log(e);
                core.material.animates[t] = null;
            }
        }, function (e) {
            console.log(e);
            core.material.animates[t] = null;
        }, "text/plain; charset=x-user-defined")
    })
}

////// 加载音频 //////
loader.prototype.loadMusic = function () {

    core.bgms.forEach(function (t) {

        // 判断是不是mid
        if (/^.*\.mid$/i.test(t)) {

            if (core.musicStatus.audioContext!=null) {
                core.material.bgms[t] = 'loading';

                core.http('GET', 'project/sounds/'+t, null, function (data) {
                    try {
                        var ff = [];
                        var mx = data.length;
                        for (var z = 0; z < mx; z++)
                            ff[z] = String.fromCharCode(data.charCodeAt(z) & 255);
                        var shouldStart = core.material.bgms[t] == 'starting';
                        core.material.bgms[t] = AudioPlayer(core.musicStatus.audioContext, Replayer(MidiFile(ff.join("")), Synth(44100)), true);

                        if (shouldStart)
                            core.playBgm(t);
                    }
                    catch (e) {
                        console.log(e);
                        core.material.bgms[t] = null;
                    }
                }, function (e) {
                    console.log(e);
                    core.material.bgms[t] = null;
                }, "text/plain; charset=x-user-defined")

            }
            else {
                core.material.bgms[t] = null;
            }
        }
        else {
            var music = new Audio();
            music.preload = 'none';
            if (main.bgmRemote) music.src = main.bgmRemoteRoot+core.firstData.name+'/'+t;
            else music.src = 'project/sounds/'+t;
            music.loop = 'loop';
            core.material.bgms[t] = music;
        }
    });

    core.sounds.forEach(function (t) {

        if (core.musicStatus.audioContext != null) {

            core.http('GET', 'project/sounds/'+t, null, function (data) {
                try {
                    core.musicStatus.audioContext.decodeAudioData(data, function (buffer) {
                        core.material.sounds[t] = buffer;
                    }, function (e) {
                        console.log(e);
                        core.material.sounds[t] = null;
                    })
                }
                catch (ee) {
                    console.log(ee);
                    core.material.sounds[t] = null;
                }
            }, function () {
                console.log(e);
                core.material.sounds[t] = null;
            }, null, 'arraybuffer');
        }
        else {
            var music = new Audio();
            music.src = 'project/sounds/'+t;
            core.material.sounds[t] = music;
        }

    });

    // 直接开始播放
    if (core.musicStatus.startDirectly && core.bgms.length>0)
        core.playBgm(core.bgms[0]);
}
