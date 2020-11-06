

// Popup object

var selectedId = null;
showPopupDetail(false);

let clickMapsEventClick = map.addListener("click", (args) => {
    selectedId = args.object.getId();
    objectName = args.object.getName();
    // show popup
    showPopupDetail(true);
    // set content for popup
    $("#popupDetail").find("#objName").html(objectName);
    $("#popupDetail").find("#objId").html(selectedId);
}, { object: true });


*//* Module show popup object *//*
function showPopupDetail(isShow) {
    if (isShow) {
        $("#popupDetail").show();
    } else {
        $("#popupDetail").hide();
    }
}
$("#popupDetail .detail-close-button").click(function (e) {
    showPopupDetail(false);
});

// Module show popup marker*//
function showPopupDetail2(isShow) {
    if (isShow) {
        $("#popupDetail2").show();
    } else {
        $("#popupDetail2").hide();
    }
}
$("#popupDetail2 .detail-close-button").click(function (e) {
    showPopupDetail2(false);
});
/*

// Bóng đổ
$("#effect__shawdown").change(function () {
    if (this.checked) {
        map.setShadowEffect(true);
    }
    else {
        map.setShadowEffect(false);
    }
});

// Đổ bóng mặt nước
$("#effect__water").change(function () {
    if (this.checked) {
        map.setWaterEffect(true);
    }
    else {
        map.setWaterEffect(false);
    }
});

// Thời gian
var timeAfternoon = function(){
    map.setTimeEffect(3);
}
var timeNight = function () {
    map.setTimeEffect(4);
}

// Thời tiết
var wheatherSun = function () {
    map.setWeather(2);
}

var wheatherRain = function () {
    map.setWeather(0);
}
var wheatherSnow = function () {
    map.setWeather(1)
}

// Control

$("#btn__switch2d").click(function () {
    $("#btn__switch3d").css("display","inline-block");
    $("#btn__switch2d").css("display", "none");
    map.enable3dMode(false);
});
$("#btn__switch3d").click(function () {
    $("#btn__switch3d").css("display", "none");
    $("#btn__switch2d").css("display", "inline-block");
    map.enable3dMode(true);
});
*//*var arrayLng = [];
var arrayPolygon = [];
map.addListener("click", (args) => {
    console.log("aaaaaaaaaa");
    arrayPolygon.push(args.location);
    arrayLng.push[arrayPolygon];
    //add poly on map
    let polygon = new map4d.Polygon({
        paths: arrayLng,
        fillColor: "#0000ff",
        fillOpacity: 1.
    })

    polygon.setMap(map)
    console.log(arrayLng);
}, { location: true })*//*

$('#btn_object').click(function () {
    console.log('aaaaa');
    let mapObject1 = new map4d.MapObject({
        id: $('#input_id').val(),
        name: $('#input_name').val(),
        height: 100,
        coordinates: [[106.707764, 10.774544],
        [106.709001, 10.773766],
        [106.708627, 10.772759],
        [106.707806, 10.774045]],
        height: 100,
        draggable: true
    })
    mapObject1.setMap(map)
});


*//*
let mapObject = new map4d.MapObject({
    id: "my_buildding",
    location: [106.707764, 10.774544],
    obj: "58a2b79436eace2398d47c01j",
    texture: "C:/Users/Admin/source/repos/MapIOTLink/Map4dIOTLink/wwwroot/img/acbdanang.jpg",

})
let mapObject = new map4d.MapObject({
    id: "myd_buildicngdddd", name: "Phuc",
    location: [106.707764, 10.7745441],
    obj: "58a2b79436eace2398d47c01",
    texture: buildImage("https://nguoiquangnam.vn/uploads/news/2017/10/img_20151012_090107_12102015085909.jpg")
});
mapObject.setMap(map);*/
/*
 let mapObject = new map4d.MapObject({
    id: "kahcdh-san", name: "Phuc",
    location: [106.707764, 10.7745441],
    obj:  "https://sw-hcm-1.vinadata.vn/v1/AUTH_4486f66f671c41bab0d3dea1904626d4/sdk/models/5eb3c2c5fc2a581128bd68a4.obj",
      texture: "https://sw-hcm-1.vinadata.vn/v1/AUTH_4486f66f671c41bab0d3dea1904626d4/sdk/textures/5e7c7ce74bc3cf1de4a871e6.JPG", draggable: true
});
mapObject.setMap(map);*//*
function buildImage(url) {
    var img = new Image();
    img.onerror = function () {
        console.log("could not load image on URL " + url);
    };
    img.src = url;
    return img;
}

// Tạo TileOverlay
*//*let tileOverlay = new map4d.TileOverlay(map4d.TileOverlayOptions = {
    getUrl: (x, y, z, _3dMode) => {
        if (!_3dMode) {
            return `https://tile.openstreetmap.de/${z}/${x}/${y}.png`
        }
        else {
            return null
        }
    },
    minZoom: 14,
    maxZoom: 17
    });
gerUrl(17, 67, 42, true);
// Set tile overlay vào map cần vẽ
tileOverlay.setMap(this.map)*//*


// Hàm chuyển lng sang x
function lon2tile(lon, zoom) {
    return (Math.floor((lon + 180) / 360 * Math.pow(2, zoom)));
}

// Hàm chuyển lat sang y
function lat2tile(lat, zoom) {
    return (Math.floor((1 - Math.log(Math.tan(lat * Math.PI / 180) + 1 / Math.cos(lat * Math.PI / 180)) / Math.PI) / 2 * Math.pow(2, zoom)));
}

// Lấy lng - lat - zoom từ Camera
var longitude = map.getCamera().target.lng;
var latitude = map.getCamera().target.lat;
var zoom = map.getCamera().zoom;

// Lấy giá trị x - y sau khi chuyển đổi 
var x = lon2tile(longitude, zoom);
var y = lon2tile(latitude, zoom);

console.log(x);
console.log(y);
console.log(zoom);*/

///////////////


//var map;
//function building()  {
//   map = new map4d.Map(document.getElementById("map"),
//        {
//            zoom: 17,
//            maxZoom: 17,
//            center: [106.707764, 10.774544],
//            tilt: 60,
//            geolocate: true,
//            accessKey: "98fd21346d83bee24dc734231f7609c9",
//            geolocate: true,
//            controls: true,
//        }
//    )
//    map.enable3dMode(true);
//    //set switch mode Auto for automatically switching between 2D & 3D
//    map.setSwitchMode(map4d.SwitchMode.Auto);
//    let buildingOverlayOptions= map4d.BuildingOverlayOptions = {
//        getUrl: (x, y, z) => {
//            return `https://lvh.vimap.vn/api/title/${z}/${x}/${y}`
//        },
//        minZoom: 17,
//        maxZoom: 19
//    }
//    //let buildingOverlay = new map4d.BuildingOverlay(map4d.BuildingOverlayOptions = {
//    //    getUrl: (x, y, z) => {
//    //        // return `https://localhost:5001/api/BuilldingOverlay/${z}/${x}/${y}`
//    //        return `https://lvh.vimap.vn/api/title/${z}/${x}/${y}`
//    //    },
//    //    minZoom: 17,
//    //    maxZoom: 19
//    //});
//    //buildingOverlay.setMap(this.map)

//    // Tạo BuildingOverlay
//    let buildingOverlay = new map4d.BuildingOverlay(buildingOverlayOptions)
//    // Set Building Overlay vào map cần vẽ
//    buildingOverlay.setMap(this.map)
//}
$(function () {
   // building();
    /*globalModule.initButton("option1", timeAfternoon);
    globalModule.initButton("option2", timeNight);
    globalModule.initButton("wheather_sun", wheatherSun);
    globalModule.initButton("wheather_rain", wheatherRain);
    globalModule.initButton("wheather_snow", wheatherSnow);

    $('input[type=radio][name=shapes]').change(function () {
        var arry = [];
        if (this.value == 'marker') {
            map.addListener("click", (args) => {
                lng_map = args.location.lng;
                lat_map = args.location.lat;
                let marker = new map4d.Marker({
                    position: { lat: lat_map, lng: lng_map },
                    anchor: [0.5, 0.5],
                    title: "Title marker",
                    snippet: "Demo description",
                    draggable: true,
                })
                //add marker on map    
                marker.setMap(map)
                // show popup
                showPopupDetail2(true);
                // set content for popup
                $("#marker_lat").html(lat_map);
                $("#marker_lng").html(lng_map);
            }, { location: true, })
        }
        else if (this.value == 'polyline') {
            map.addListener("click", (args) => {
                let poly = new map4d.Polyline({
                    path: arry,
                    strokeColor: "#ff0000",
                    strokeOpacity: 1.0,
                    strokeWidth: 3,
                })
                arry.push(args.location);

                //add poly on map    
                poly.setMap(map)

            }, { location: true })
        }
        else if (this.value == 'cricle') {
            map.addListener("click", (args) => {
                lngCirle = args.location;
                let cirle = new map4d.Circle({
                    center: lngCirle,
                    fillColor: "#ff0000",
                    radius: 100,
                })

                //add cricle on map    
                cirle.setMap(map)

            }, { location: true })
        }
    });*/
});