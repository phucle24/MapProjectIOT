
var map = new map4d.Map(document.getElementById("map"),
    {
        zoom: 17,
        maxZoom: 17,
        center: [106.707764, 10.774544],
        tilt: 60,
        geolocate: true,
        accessKey: "98fd21346d83bee24dc734231f7609c9",
        geolocate: true,
        controls: true,
    }
)
map.enable3dMode(true);
//set switch mode Auto for automatically switching between 2D & 3D
map.setSwitchMode(map4d.SwitchMode.Auto);

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


/* Module show popup object */
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

/* Module show popup marker*/
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
/*var arrayLng = [];
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
}, { location: true })*/

$('#btn_object').click(function () {
    console.log('aaaaa');
    let mapObject = new map4d.MapObject({
        id: $('#input_id').val(),
        name: $('#input_name').val(),
        coordinates: [[106.707764, 10.774544],
        [106.709001, 10.773766],
        [106.708627, 10.772759],
        [106.707806, 10.774045]],
        height: 100,
        draggable: true
    })
    mapObject.setMap(map)
});
$(function () {
    globalModule.initButton("option1", timeAfternoon);
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
    });
});