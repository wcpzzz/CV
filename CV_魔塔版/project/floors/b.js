main.floors.b=
{
"floorId": "b",
"title": "中学",
"name": "0",
"width": 13,
"height": 13,
"canFlyTo": true,
"canUseQuickShop": true,
"images": [],
"item_ratio": 2,
"defaultGround": "ground",
"bgm": "bgm.mp3",
"firstArrive": [],
"events": {
    "8,3": [
        {
            "type": "if",
            "condition": "flag:woman_times==0",
            "true": [
                {
                    "type": "setValue",
                    "name": "flag:door2",
                    "value": "flag:door2+1"
                },
                {
                    "type": "if",
                    "condition": "flag:door2==1",
                    "true": [
                        {
                            "type": "openDoor",
                            "loc": [
                                6,
                                3
                            ]
                        }
                    ],
                    "false": []
                },
                {
                    "type": "setValue",
                    "name": "item:yellowKey",
                    "value": "item:yellowKey+1"
                },
                "\t[父亲,man]这是你的转学黄钥匙。（黄钥匙+1）"
            ],
            "false": [
                "\t[父亲,man]爸爸相信你，是金子，在哪里都会发光的。",
                {
                    "type": "exit"
                }
            ]
        },
        {
            "type": "setValue",
            "name": "flag:woman_times",
            "value": "flag:woman_times+1"
        },
        {
            "type": "revisit"
        }
    ],
    "4,2": [
        "恭喜wcpzzz同学，以668分年级第一百好几的成绩，于2011年6月毕业，升入南京市金陵中学河西分校最好的班。望再接再厉，为母校争光。",
        {
            "type": "hide",
            "time": 500
        },
        "\t[wcpzzz,hero]这还恭喜个什么啊，我不要进分校，我要进本校啊！",
        "\t[旁白]那时的wcpzzz垂头丧气，觉得自己发挥失常了，但是殊不知，和后面的人生相比，这一点挫折就如鸿雁展翅时散落的羽毛，不值得如何的留恋和懊悔。"
    ],
    "5,2": [
        "\t[少女,npc0]校长（wcpzzz的外号），年级前100就可以上金陵中学了，你有把握吗？",
        "\t[wcpzzz,hero]真没什么把握。一个年级22个班，那两个数学班的人都好厉害。我文科又不怎么样……【底气不足】",
        "\t[少女,npc0]别那么没自信嘛，你都没自信，那我就更没自信了。【日常鼓励】",
        {
            "type": "hide",
            "time": 500
        }
    ],
    "8,4": null,
    "8,11": [
        "上海市罗南中学"
    ],
    "4,11": [
        "南京市金陵中学"
    ]
},
"changeFloor": {
    "3,2": {
        "floorId": "c",
        "loc": [
            6,
            12
        ],
        "time": 500
    },
    "6,12": null
},
"afterBattle": {
    "4,6": [
        {
            "type": "setValue",
            "name": "flag:door",
            "value": "flag:door+1"
        },
        {
            "type": "if",
            "condition": "flag:door==1",
            "true": [
                "\t[wcpzzz,hero]想不到，想不到对手竟会这么强！我不行了，已经无法再战斗下去了。",
                "\t[旁白]于是，wcpzzz带着遗憾，即将奔赴中考考场。美玉透光折射的瑕疵，隐隐间已然摧毁了那曾经的年少轻狂。",
                "\t[旁白]但也仅此而已。摧毁之后，也只剩迷茫罢了。",
                {
                    "type": "openDoor",
                    "loc": [
                        6,
                        9
                    ]
                }
            ],
            "false": []
        }
    ],
    "4,8": [
        "\t[wcpzzz,hero]还好吧，虽然是强了那么一点，难打了那么……但我还是赢了呀。大不了努努力，努努力的话……"
    ],
    "4,7": [
        "\t[wcpzzz,hero]对手又厉害了，我，真的能是天才吗，真的，又能战斗到何种程度呢？"
    ]
},
"afterGetItem": {},
"afterOpenDoor": {},
"cannotMove": {
    "7,4": null
},
"map": [
    [  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4],
    [  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4],
    [  4,  4,  4, 87,129,132,  0,  0,  0,  0,  4,  4,  4],
    [  4,  4,  4,  1,225,  1, 85,  1,121,  1,  4,  4,  4],
    [  4,  4,  4,  1,224,  1,  0,  1,202,  1,  4,  4,  4],
    [  4,  4,  4,  1,223,  1,  0,  1,202,  1,  4,  4,  4],
    [  4,  4,  4,  1,204,  1,  0,  1,202,  1,  4,  4,  4],
    [  4,  4,  4,  1,203,  1,  0,  1,202,  1,  4,  4,  4],
    [  4,  4,  4,  1,202,  1,  0,  1,202,  1,  4,  4,  4],
    [  4,  4,  4,  1, 81,  1, 85,  1, 83,  1,  4,  4,  4],
    [  4,  4,  4,  4,  0,  0,  0,  0, 23,  4,  4,  4,  4],
    [  4,  4,  4,  4,129,  0,  0,  0,129,  4,  4,  4,  4],
    [  4,  4,  4,  4,  0,  0,  0,  0,  0,  4,  4,  4,  4]
],
"bgmap": [

],
"fgmap": [

],
}