/* 1. Marker */
// Create marker with information
let marker = new map4d.Marker({
    title: "Map title",
    snippet: "Le Van Phuc",
    position: { lat: 16.073210, lng: 108.219779 }
});
marker.setMap(this.map);

// Create marker with icon View

let marker1 = new map4d.Marker({
    iconView: `<div style=\"width: 32px; height: 32px; background-color: red; text-align: center; color: #000000;\">Text</div>`, // icon view of marker
    anchor: [0.5, 0.5], // Điểm neo
    position: { lat: 16.083210, lng: 108.319779 }
});

// Detele marker

    // marker.setMap(null);

// Write text on marker

let marker2 = new map4d.Marker({
    anchor: [0.5, 1.0],
    label: new map4d.MarkerLabel({ text: "Phuc", color: "000000", fontSize: 12 })
    position: { lat: 16.083210, lng: 108.319779 }
});

// Draggable marker

let marker3 = new map4d.Marker({
    position: { lat: 16.083210, lng: 108.319779 },
    draggable: true
})
marker3.setMap(map) 


/* 2. Polyline*/
//tạo đối tượng polyline từ PolylineOptions
let polyline = new map4d.Polyline({
    path: [
        [106.699380, 10.772431],
        [106.700147, 10.773201],
        [106.700763, 10.771783],
        [106.701901, 10.772302],
        [106.701493, 10.773267],
        [106.702835, 10.773599]
    ],
    strokeColor: "blue", // Màu sắc
    strokeOpacity: 1.0, // Độ trong suốt
    strokeWidth: 10, // Chiều rộng
    draggable: true, // Cho phép duy chuyển plygon
    closed: true, // Nối 2 điểm đầu cuối polygon
    evlevation: 200, // Độ cao so với mực nước biển
    style: "dotted" // Kiểu nét đứt
})
//thêm polyline vào map    
polyline.setMap(map)

/* 3. Polygon */

let polygon = new map4d.Polygon(map4d.PolygonOptions = {
    paths:
        [[{ lat: 10.773201, lng: 106.700147 }, { lat: 10.771783, lng: 106.700763 },
        { lat: 10.772302, lng: 106.701901 }, { lat: 10.773267, lng: 106.701493 },
        { lat: 10.773201, lng: 106.700147 }]],
    fillColor: "#0000ff", // Màu sắc bên trong
    fillOpacity: 1.0, // Đột trong suốt
    strokeColor: "#00ff00" // màu viền xung quanh
    //strokeWidth: 0.0 // nếu không muốn vẽ viền

})
// Polygon 2 lỗ
    let polygon = new map4d.Polygon(map4d.PolygonOptions = {
        paths:
            [[{ lat: 10.773201, lng: 106.700147 }, { lat: 10.771783, lng: 106.700763 },
            { lat: 10.772302, lng: 106.701901 }, { lat: 10.773267, lng: 106.701493 },
            { lat: 10.773201, lng: 106.700147 }],
            // hole1
            [{ lat: 10.772785, lng: 106.700738 }, { lat: 10.772904, lng: 106.701304 },
            { lat: 10.772752, lng: 106.701319 }, { lat: 10.772650, lng: 106.700651 },
            { lat: 10.772785, lng: 106.700738 }],
            // hole2
            [{ lat: 10.772356, lng: 106.700802 }, { lat: 10.772479, lng: 106.701413 },
            { lat: 10.772285, lng: 106.701497 }, { lat: 10.772059, lng: 106.701064 },
            { lat: 10.772356, lng: 106.700802 }]],
    })


polygon.setMap(this.map) // Add polygon
//polygon.setMap(null) // Delete polygon


/* 4. Cirle*/

//tạo đối tượng circle từ CircleOptions
let circle = new map4d.Circle({
    center: { lat: 10.773201, lng: 106.700147 }, // Tạo điểm trung tâm
    fillColor: "#ff0000", 
    radius: 100, // Kích thước hình tròn
    strokeWidth: 2.0, // Độ rộng của viền
    strokeColor: "#0000ff" // Màu viền
})

//thêm circle vào map    
circle.setMap(this.map)

/* Z-index lớn hơn sẽ ghi dè lên */
let circleA = new map4d.Circle({
    center: { lat: 10.773201, lng: 106.700147 }, radius: 50, zIndex: 15, draggable: true,
    fillColor: "#0000ff", strokeWidth: 5
})

//thêm circle vào map
circleA.setMap(this.map)

let circleB = new map4d.Circle({
    center: { lat: 10.773201, lng: 106.700147 }, radius: 100, zIndex: 10, draggable: true,
    fillColor: "#ff0000", strokeWidth: 5
})

/* Add 3D Object on map*/
let mapObject = new map4d.MapObject({
    id: "my_building", // Chỉ duy nhất 1 id
    location: [106.699380, 10.772431],
    obj: "58a2b79436eace2398d47c01", // Model id của object trên hệ thống
    texture: "CauKhanhHoi.png"
})
mapObject.setMap(map)

// Ẩn hiện ID

// setHiddenObject("5f252b3efbcd7b6dfb4c9478"): void


/* 5. Tilte Area => Tạo ra 1 khu vực */ 


// Tạo tileAreaOptions
let tileAreaOption: map4d.TileAreaOptions = {
    bounds:
        new map4d.LatLngBounds([104.699308, 8.606498], [107.974320, 10.567800]),
    url: "http://a.tile.openstreetmap.fr/hot/{z}/{x}/{y}.png",
}
// Tạo TileArea
let tileArea = new map4d.TileArea(tileAreaOption)
// Cài đặt map cần vẽ
tileArea.setMap(map)


/* 6. Effect */

map.setTimeEffect()   // thời điểm trong ngày : sáng trưa chiều tối
map.setWeather()      // thời tiết : nắng, mưa, tuyết
map.setWaterEffect()  // Hiệu ứng mặt nước
map.setShadowEffect() // Bóng đổ

