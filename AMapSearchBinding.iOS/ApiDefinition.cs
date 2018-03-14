using System;
using CoreLocation;
using Foundation;
using ObjCRuntime;

using AMapSearchBinding.iOS;

namespace AMapSearchBinding.iOS
{
    [Static]
    //[Verify(ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // extern NSString *const AMapSearchVersion;
        [Field("AMapSearchVersion", "__Internal")]
        NSString AMapSearchVersion { get; }

        // extern NSString *const AMapSearchName;
        [Field("AMapSearchName", "__Internal")]
        NSString AMapSearchName { get; }

        // extern NSString *const AMapSearchErrorDomain;
        [Field("AMapSearchErrorDomain", "__Internal")]
        NSString AMapSearchErrorDomain { get; }
    }

    // @interface AMapSearchObject : NSObject <NSCopying, NSCoding>
    [BaseType(typeof(NSObject))]
    interface AMapSearchObject : INSCopying, INSCoding
    {
        // -(NSString *)formattedDescription;
        [Export("formattedDescription")]
        //[Verify(MethodToProperty)]
        string FormattedDescription { get; }
    }

    // @interface AMapGeoPoint : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapGeoPoint
    {
        // @property (assign, nonatomic) CGFloat latitude;
        [Export("latitude")]
        nfloat Latitude { get; set; }

        // @property (assign, nonatomic) CGFloat longitude;
        [Export("longitude")]
        nfloat Longitude { get; set; }

        // +(AMapGeoPoint *)locationWithLatitude:(CGFloat)lat longitude:(CGFloat)lon;
        [Static]
        [Export("locationWithLatitude:longitude:")]
        AMapGeoPoint LocationWithLatitude(nfloat lat, nfloat lon);
    }

    // @interface AMapGeoPolygon : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapGeoPolygon
    {
        // @property (nonatomic, strong) NSArray<AMapGeoPoint *> * points;
        [Export("points", ArgumentSemantic.Strong)]
        AMapGeoPoint[] Points { get; set; }

        // +(AMapGeoPolygon *)polygonWithPoints:(NSArray *)points;
        [Static]
        [Export("polygonWithPoints:")]
        //[Verify(StronglyTypedNSArray)]
        AMapGeoPolygon PolygonWithPoints(NSObject[] points);
    }

    // @interface AMapCity : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapCity
    {
        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * citycode;
        [Export("citycode")]
        string Citycode { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (assign, nonatomic) NSInteger num;
        [Export("num")]
        nint Num { get; set; }

        // @property (nonatomic, strong) NSArray<AMapDistrict *> * districts;
        [Export("districts", ArgumentSemantic.Strong)]
        AMapDistrict[] Districts { get; set; }
    }

    // @interface AMapSuggestion : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapSuggestion
    {
        // @property (nonatomic, strong) NSArray<NSString *> * keywords;
        [Export("keywords", ArgumentSemantic.Strong)]
        string[] Keywords { get; set; }

        // @property (nonatomic, strong) NSArray<AMapCity *> * cities;
        [Export("cities", ArgumentSemantic.Strong)]
        AMapCity[] Cities { get; set; }
    }

    // @interface AMapTip : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapTip
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * district;
        [Export("district")]
        string District { get; set; }

        // @property (copy, nonatomic) NSString * address;
        [Export("address")]
        string Address { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * typecode;
        [Export("typecode")]
        string Typecode { get; set; }
    }

    // @interface AMapImage : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapImage
    {
        // @property (copy, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; set; }

        // @property (copy, nonatomic) NSString * url;
        [Export("url")]
        string Url { get; set; }
    }

    // @interface AMapPOIExtension : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapPOIExtension
    {
        // @property (assign, nonatomic) CGFloat rating;
        [Export("rating")]
        nfloat Rating { get; set; }

        // @property (assign, nonatomic) CGFloat cost;
        [Export("cost")]
        nfloat Cost { get; set; }

        // @property (copy, nonatomic) NSString * openTime;
        [Export("openTime")]
        string OpenTime { get; set; }
    }

    // @interface AMapIndoorData : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapIndoorData
    {
        // @property (assign, nonatomic) NSInteger floor;
        [Export("floor")]
        nint Floor { get; set; }

        // @property (copy, nonatomic) NSString * floorName;
        [Export("floorName")]
        string FloorName { get; set; }

        // @property (copy, nonatomic) NSString * pid;
        [Export("pid")]
        string Pid { get; set; }
    }

    // @interface AMapSubPOI : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapSubPOI
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * sname;
        [Export("sname")]
        string Sname { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * address;
        [Export("address")]
        string Address { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (copy, nonatomic) NSString * subtype;
        [Export("subtype")]
        string Subtype { get; set; }
    }

    // @interface AMapRoutePOI : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRoutePOI
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; set; }
    }

    // @interface AMapPOI : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapPOI
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; set; }

        // @property (copy, nonatomic) NSString * typecode;
        [Export("typecode")]
        string Typecode { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * address;
        [Export("address")]
        string Address { get; set; }

        // @property (copy, nonatomic) NSString * tel;
        [Export("tel")]
        string Tel { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (copy, nonatomic) NSString * parkingType;
        [Export("parkingType")]
        string ParkingType { get; set; }

        // @property (copy, nonatomic) NSString * shopID;
        [Export("shopID")]
        string ShopID { get; set; }

        // @property (copy, nonatomic) NSString * postcode;
        [Export("postcode")]
        string Postcode { get; set; }

        // @property (copy, nonatomic) NSString * website;
        [Export("website")]
        string Website { get; set; }

        // @property (copy, nonatomic) NSString * email;
        [Export("email")]
        string Email { get; set; }

        // @property (copy, nonatomic) NSString * province;
        [Export("province")]
        string Province { get; set; }

        // @property (copy, nonatomic) NSString * pcode;
        [Export("pcode")]
        string Pcode { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * citycode;
        [Export("citycode")]
        string Citycode { get; set; }

        // @property (copy, nonatomic) NSString * district;
        [Export("district")]
        string District { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * gridcode;
        [Export("gridcode")]
        string Gridcode { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * enterLocation;
        [Export("enterLocation", ArgumentSemantic.Copy)]
        AMapGeoPoint EnterLocation { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * exitLocation;
        [Export("exitLocation", ArgumentSemantic.Copy)]
        AMapGeoPoint ExitLocation { get; set; }

        // @property (copy, nonatomic) NSString * direction;
        [Export("direction")]
        string Direction { get; set; }

        // @property (assign, nonatomic) BOOL hasIndoorMap;
        [Export("hasIndoorMap")]
        bool HasIndoorMap { get; set; }

        // @property (copy, nonatomic) NSString * businessArea;
        [Export("businessArea")]
        string BusinessArea { get; set; }

        // @property (nonatomic, strong) AMapIndoorData * indoorData;
        [Export("indoorData", ArgumentSemantic.Strong)]
        AMapIndoorData IndoorData { get; set; }

        // @property (nonatomic, strong) NSArray<AMapSubPOI *> * subPOIs;
        [Export("subPOIs", ArgumentSemantic.Strong)]
        AMapSubPOI[] SubPOIs { get; set; }

        // @property (nonatomic, strong) NSArray<AMapImage *> * images;
        [Export("images", ArgumentSemantic.Strong)]
        AMapImage[] Images { get; set; }

        // @property (nonatomic, strong) AMapPOIExtension * extensionInfo;
        [Export("extensionInfo", ArgumentSemantic.Strong)]
        AMapPOIExtension ExtensionInfo { get; set; }
    }

    // @interface AMapAOI : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapAOI
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (assign, nonatomic) CGFloat area;
        [Export("area")]
        nfloat Area { get; set; }
    }

    // @interface AMapRoad : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRoad
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (copy, nonatomic) NSString * direction;
        [Export("direction")]
        string Direction { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }
    }

    // @interface AMapRoadInter : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRoadInter
    {
        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (copy, nonatomic) NSString * direction;
        [Export("direction")]
        string Direction { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * firstId;
        [Export("firstId")]
        string FirstId { get; set; }

        // @property (copy, nonatomic) NSString * firstName;
        [Export("firstName")]
        string FirstName { get; set; }

        // @property (copy, nonatomic) NSString * secondId;
        [Export("secondId")]
        string SecondId { get; set; }

        // @property (copy, nonatomic) NSString * secondName;
        [Export("secondName")]
        string SecondName { get; set; }
    }

    // @interface AMapStreetNumber : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapStreetNumber
    {
        // @property (copy, nonatomic) NSString * street;
        [Export("street")]
        string Street { get; set; }

        // @property (copy, nonatomic) NSString * number;
        [Export("number")]
        string Number { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (copy, nonatomic) NSString * direction;
        [Export("direction")]
        string Direction { get; set; }
    }

    // @interface AMapBusinessArea : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapBusinessArea
    {
        // @property (nonatomic, strong) NSString * name;
        [Export("name", ArgumentSemantic.Strong)]
        string Name { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }
    }

    // @interface AMapAddressComponent : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapAddressComponent
    {
        // @property (copy, nonatomic) NSString * country;
        [Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * province;
        [Export("province")]
        string Province { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * citycode;
        [Export("citycode")]
        string Citycode { get; set; }

        // @property (copy, nonatomic) NSString * district;
        [Export("district")]
        string District { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * township;
        [Export("township")]
        string Township { get; set; }

        // @property (copy, nonatomic) NSString * towncode;
        [Export("towncode")]
        string Towncode { get; set; }

        // @property (copy, nonatomic) NSString * neighborhood;
        [Export("neighborhood")]
        string Neighborhood { get; set; }

        // @property (copy, nonatomic) NSString * building;
        [Export("building")]
        string Building { get; set; }

        // @property (nonatomic, strong) AMapStreetNumber * streetNumber;
        [Export("streetNumber", ArgumentSemantic.Strong)]
        AMapStreetNumber StreetNumber { get; set; }

        // @property (nonatomic, strong) NSArray<AMapBusinessArea *> * businessAreas;
        [Export("businessAreas", ArgumentSemantic.Strong)]
        AMapBusinessArea[] BusinessAreas { get; set; }
    }

    // @interface AMapReGeocode : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapReGeocode
    {
        // @property (copy, nonatomic) NSString * formattedAddress;
        [Export("formattedAddress")]
        string FormattedAddress { get; set; }

        // @property (nonatomic, strong) AMapAddressComponent * addressComponent;
        [Export("addressComponent", ArgumentSemantic.Strong)]
        AMapAddressComponent AddressComponent { get; set; }

        // @property (nonatomic, strong) NSArray<AMapRoad *> * roads;
        [Export("roads", ArgumentSemantic.Strong)]
        AMapRoad[] Roads { get; set; }

        // @property (nonatomic, strong) NSArray<AMapRoadInter *> * roadinters;
        [Export("roadinters", ArgumentSemantic.Strong)]
        AMapRoadInter[] Roadinters { get; set; }

        // @property (nonatomic, strong) NSArray<AMapPOI *> * pois;
        [Export("pois", ArgumentSemantic.Strong)]
        AMapPOI[] Pois { get; set; }

        // @property (nonatomic, strong) NSArray<AMapAOI *> * aois;
        [Export("aois", ArgumentSemantic.Strong)]
        AMapAOI[] Aois { get; set; }
    }

    // @interface AMapGeocode : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapGeocode
    {
        // @property (copy, nonatomic) NSString * formattedAddress;
        [Export("formattedAddress")]
        string FormattedAddress { get; set; }

        // @property (copy, nonatomic) NSString * province;
        [Export("province")]
        string Province { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * citycode;
        [Export("citycode")]
        string Citycode { get; set; }

        // @property (copy, nonatomic) NSString * district;
        [Export("district")]
        string District { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * township;
        [Export("township")]
        string Township { get; set; }

        // @property (copy, nonatomic) NSString * neighborhood;
        [Export("neighborhood")]
        string Neighborhood { get; set; }

        // @property (copy, nonatomic) NSString * building;
        [Export("building")]
        string Building { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * level;
        [Export("level")]
        string Level { get; set; }
    }

    // @interface AMapBusStop : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapBusStop
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * citycode;
        [Export("citycode")]
        string Citycode { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (nonatomic, strong) NSArray<AMapBusLine *> * buslines;
        [Export("buslines", ArgumentSemantic.Strong)]
        AMapBusLine[] Buslines { get; set; }

        // @property (copy, nonatomic) NSString * sequence;
        [Export("sequence")]
        string Sequence { get; set; }
    }

    // @interface AMapBusLine : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapBusLine
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * polyline;
        [Export("polyline")]
        string Polyline { get; set; }

        // @property (copy, nonatomic) NSString * citycode;
        [Export("citycode")]
        string Citycode { get; set; }

        // @property (copy, nonatomic) NSString * startStop;
        [Export("startStop")]
        string StartStop { get; set; }

        // @property (copy, nonatomic) NSString * endStop;
        [Export("endStop")]
        string EndStop { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * startTime;
        [Export("startTime")]
        string StartTime { get; set; }

        // @property (copy, nonatomic) NSString * endTime;
        [Export("endTime")]
        string EndTime { get; set; }

        // @property (copy, nonatomic) NSString * company;
        [Export("company")]
        string Company { get; set; }

        // @property (assign, nonatomic) CGFloat distance;
        [Export("distance")]
        nfloat Distance { get; set; }

        // @property (assign, nonatomic) CGFloat basicPrice;
        [Export("basicPrice")]
        nfloat BasicPrice { get; set; }

        // @property (assign, nonatomic) CGFloat totalPrice;
        [Export("totalPrice")]
        nfloat TotalPrice { get; set; }

        // @property (copy, nonatomic) AMapGeoPolygon * bounds;
        [Export("bounds", ArgumentSemantic.Copy)]
        AMapGeoPolygon Bounds { get; set; }

        // @property (nonatomic, strong) NSArray<AMapBusStop *> * busStops;
        [Export("busStops", ArgumentSemantic.Strong)]
        AMapBusStop[] BusStops { get; set; }

        // @property (nonatomic, strong) AMapBusStop * departureStop;
        [Export("departureStop", ArgumentSemantic.Strong)]
        AMapBusStop DepartureStop { get; set; }

        // @property (nonatomic, strong) AMapBusStop * arrivalStop;
        [Export("arrivalStop", ArgumentSemantic.Strong)]
        AMapBusStop ArrivalStop { get; set; }

        // @property (nonatomic, strong) NSArray<AMapBusStop *> * viaBusStops;
        [Export("viaBusStops", ArgumentSemantic.Strong)]
        AMapBusStop[] ViaBusStops { get; set; }

        // @property (assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; set; }
    }

    // @interface AMapDistrict : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapDistrict
    {
        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * citycode;
        [Export("citycode")]
        string Citycode { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * level;
        [Export("level")]
        string Level { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * center;
        [Export("center", ArgumentSemantic.Copy)]
        AMapGeoPoint Center { get; set; }

        // @property (nonatomic, strong) NSArray<AMapDistrict *> * districts;
        [Export("districts", ArgumentSemantic.Strong)]
        AMapDistrict[] Districts { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * polylines;
        [Export("polylines", ArgumentSemantic.Strong)]
        string[] Polylines { get; set; }
    }

    // @interface AMapTMC : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapTMC
    {
        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (copy, nonatomic) NSString * status;
        [Export("status")]
        string Status { get; set; }

        // @property (copy, nonatomic) NSString * polyline;
        [Export("polyline")]
        string Polyline { get; set; }
    }

    // @interface AMapStep : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapStep
    {
        // @property (copy, nonatomic) NSString * instruction;
        [Export("instruction")]
        string Instruction { get; set; }

        // @property (copy, nonatomic) NSString * orientation;
        [Export("orientation")]
        string Orientation { get; set; }

        // @property (copy, nonatomic) NSString * road;
        [Export("road")]
        string Road { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; set; }

        // @property (copy, nonatomic) NSString * polyline;
        [Export("polyline")]
        string Polyline { get; set; }

        // @property (copy, nonatomic) NSString * action;
        [Export("action")]
        string Action { get; set; }

        // @property (copy, nonatomic) NSString * assistantAction;
        [Export("assistantAction")]
        string AssistantAction { get; set; }

        // @property (assign, nonatomic) CGFloat tolls;
        [Export("tolls")]
        nfloat Tolls { get; set; }

        // @property (assign, nonatomic) NSInteger tollDistance;
        [Export("tollDistance")]
        nint TollDistance { get; set; }

        // @property (copy, nonatomic) NSString * tollRoad;
        [Export("tollRoad")]
        string TollRoad { get; set; }

        // @property (nonatomic, strong) NSArray<AMapCity *> * cities;
        [Export("cities", ArgumentSemantic.Strong)]
        AMapCity[] Cities { get; set; }

        // @property (nonatomic, strong) NSArray<AMapTMC *> * tmcs;
        [Export("tmcs", ArgumentSemantic.Strong)]
        AMapTMC[] Tmcs { get; set; }
    }

    // @interface AMapPath : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapPath
    {
        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; set; }

        // @property (copy, nonatomic) NSString * strategy;
        [Export("strategy")]
        string Strategy { get; set; }

        // @property (nonatomic, strong) NSArray<AMapStep *> * steps;
        [Export("steps", ArgumentSemantic.Strong)]
        AMapStep[] Steps { get; set; }

        // @property (assign, nonatomic) CGFloat tolls;
        [Export("tolls")]
        nfloat Tolls { get; set; }

        // @property (assign, nonatomic) NSInteger tollDistance;
        [Export("tollDistance")]
        nint TollDistance { get; set; }

        // @property (assign, nonatomic) NSInteger totalTrafficLights;
        [Export("totalTrafficLights")]
        nint TotalTrafficLights { get; set; }

        // @property (assign, nonatomic) NSInteger restriction;
        [Export("restriction")]
        nint Restriction { get; set; }
    }

    // @interface AMapWalking : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapWalking
    {
        // @property (copy, nonatomic) AMapGeoPoint * origin;
        [Export("origin", ArgumentSemantic.Copy)]
        AMapGeoPoint Origin { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * destination;
        [Export("destination", ArgumentSemantic.Copy)]
        AMapGeoPoint Destination { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; set; }

        // @property (nonatomic, strong) NSArray<AMapStep *> * steps;
        [Export("steps", ArgumentSemantic.Strong)]
        AMapStep[] Steps { get; set; }
    }

    // @interface AMapTaxi : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapTaxi
    {
        // @property (copy, nonatomic) AMapGeoPoint * origin;
        [Export("origin", ArgumentSemantic.Copy)]
        AMapGeoPoint Origin { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * destination;
        [Export("destination", ArgumentSemantic.Copy)]
        AMapGeoPoint Destination { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; set; }

        // @property (copy, nonatomic) NSString * sname;
        [Export("sname")]
        string Sname { get; set; }

        // @property (copy, nonatomic) NSString * tname;
        [Export("tname")]
        string Tname { get; set; }
    }

    // @interface AMapRailwayStation : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRailwayStation
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * time;
        [Export("time")]
        string Time { get; set; }

        // @property (assign, nonatomic) NSInteger wait;
        [Export("wait")]
        nint Wait { get; set; }

        // @property (assign, nonatomic) BOOL isStart;
        [Export("isStart")]
        bool IsStart { get; set; }

        // @property (assign, nonatomic) BOOL isEnd;
        [Export("isEnd")]
        bool IsEnd { get; set; }
    }

    // @interface AMapRailwaySpace : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRailwaySpace
    {
        // @property (copy, nonatomic) NSString * code;
        [Export("code")]
        string Code { get; set; }

        // @property (assign, nonatomic) CGFloat cost;
        [Export("cost")]
        nfloat Cost { get; set; }
    }

    // @interface AMapRailway : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRailway
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * trip;
        [Export("trip")]
        string Trip { get; set; }

        // @property (copy, nonatomic) NSString * type;
        [Export("type")]
        string Type { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (assign, nonatomic) NSInteger time;
        [Export("time")]
        nint Time { get; set; }

        // @property (nonatomic, strong) AMapRailwayStation * departureStation;
        [Export("departureStation", ArgumentSemantic.Strong)]
        AMapRailwayStation DepartureStation { get; set; }

        // @property (nonatomic, strong) AMapRailwayStation * arrivalStation;
        [Export("arrivalStation", ArgumentSemantic.Strong)]
        AMapRailwayStation ArrivalStation { get; set; }

        // @property (nonatomic, strong) NSArray<AMapRailwaySpace *> * spaces;
        [Export("spaces", ArgumentSemantic.Strong)]
        AMapRailwaySpace[] Spaces { get; set; }

        // @property (nonatomic, strong) NSArray<AMapRailwayStation *> * viaStops;
        [Export("viaStops", ArgumentSemantic.Strong)]
        AMapRailwayStation[] ViaStops { get; set; }

        // @property (nonatomic, strong) NSArray<AMapRailway *> * alters;
        [Export("alters", ArgumentSemantic.Strong)]
        AMapRailway[] Alters { get; set; }
    }

    // @interface AMapSegment : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapSegment
    {
        // @property (nonatomic, strong) AMapWalking * walking;
        [Export("walking", ArgumentSemantic.Strong)]
        AMapWalking Walking { get; set; }

        // @property (nonatomic, strong) NSArray<AMapBusLine *> * buslines;
        [Export("buslines", ArgumentSemantic.Strong)]
        AMapBusLine[] Buslines { get; set; }

        // @property (nonatomic, strong) AMapTaxi * taxi;
        [Export("taxi", ArgumentSemantic.Strong)]
        AMapTaxi Taxi { get; set; }

        // @property (nonatomic, strong) AMapRailway * railway;
        [Export("railway", ArgumentSemantic.Strong)]
        AMapRailway Railway { get; set; }

        // @property (copy, nonatomic) NSString * enterName;
        [Export("enterName")]
        string EnterName { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * enterLocation;
        [Export("enterLocation", ArgumentSemantic.Copy)]
        AMapGeoPoint EnterLocation { get; set; }

        // @property (copy, nonatomic) NSString * exitName;
        [Export("exitName")]
        string ExitName { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * exitLocation;
        [Export("exitLocation", ArgumentSemantic.Copy)]
        AMapGeoPoint ExitLocation { get; set; }
    }

    // @interface AMapTransit : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapTransit
    {
        // @property (assign, nonatomic) CGFloat cost;
        [Export("cost")]
        nfloat Cost { get; set; }

        // @property (assign, nonatomic) NSInteger duration;
        [Export("duration")]
        nint Duration { get; set; }

        // @property (assign, nonatomic) BOOL nightflag;
        [Export("nightflag")]
        bool Nightflag { get; set; }

        // @property (assign, nonatomic) NSInteger walkingDistance;
        [Export("walkingDistance")]
        nint WalkingDistance { get; set; }

        // @property (nonatomic, strong) NSArray<AMapSegment *> * segments;
        [Export("segments", ArgumentSemantic.Strong)]
        AMapSegment[] Segments { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }
    }

    // @interface AMapRoute : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRoute
    {
        // @property (copy, nonatomic) AMapGeoPoint * origin;
        [Export("origin", ArgumentSemantic.Copy)]
        AMapGeoPoint Origin { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * destination;
        [Export("destination", ArgumentSemantic.Copy)]
        AMapGeoPoint Destination { get; set; }

        // @property (assign, nonatomic) CGFloat taxiCost;
        [Export("taxiCost")]
        nfloat TaxiCost { get; set; }

        // @property (nonatomic, strong) NSArray<AMapPath *> * paths;
        [Export("paths", ArgumentSemantic.Strong)]
        AMapPath[] Paths { get; set; }

        // @property (nonatomic, strong) NSArray<AMapTransit *> * transits;
        [Export("transits", ArgumentSemantic.Strong)]
        AMapTransit[] Transits { get; set; }
    }

    // @interface AMapLocalWeatherLive : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapLocalWeatherLive
    {
        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * province;
        [Export("province")]
        string Province { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * weather;
        [Export("weather")]
        string Weather { get; set; }

        // @property (copy, nonatomic) NSString * temperature;
        [Export("temperature")]
        string Temperature { get; set; }

        // @property (copy, nonatomic) NSString * windDirection;
        [Export("windDirection")]
        string WindDirection { get; set; }

        // @property (copy, nonatomic) NSString * windPower;
        [Export("windPower")]
        string WindPower { get; set; }

        // @property (copy, nonatomic) NSString * humidity;
        [Export("humidity")]
        string Humidity { get; set; }

        // @property (copy, nonatomic) NSString * reportTime;
        [Export("reportTime")]
        string ReportTime { get; set; }
    }

    // @interface AMapLocalDayWeatherForecast : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapLocalDayWeatherForecast
    {
        // @property (copy, nonatomic) NSString * date;
        [Export("date")]
        string Date { get; set; }

        // @property (copy, nonatomic) NSString * week;
        [Export("week")]
        string Week { get; set; }

        // @property (copy, nonatomic) NSString * dayWeather;
        [Export("dayWeather")]
        string DayWeather { get; set; }

        // @property (copy, nonatomic) NSString * nightWeather;
        [Export("nightWeather")]
        string NightWeather { get; set; }

        // @property (copy, nonatomic) NSString * dayTemp;
        [Export("dayTemp")]
        string DayTemp { get; set; }

        // @property (copy, nonatomic) NSString * nightTemp;
        [Export("nightTemp")]
        string NightTemp { get; set; }

        // @property (copy, nonatomic) NSString * dayWind;
        [Export("dayWind")]
        string DayWind { get; set; }

        // @property (copy, nonatomic) NSString * nightWind;
        [Export("nightWind")]
        string NightWind { get; set; }

        // @property (copy, nonatomic) NSString * dayPower;
        [Export("dayPower")]
        string DayPower { get; set; }

        // @property (copy, nonatomic) NSString * nightPower;
        [Export("nightPower")]
        string NightPower { get; set; }
    }

    // @interface AMapLocalWeatherForecast : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapLocalWeatherForecast
    {
        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }

        // @property (copy, nonatomic) NSString * province;
        [Export("province")]
        string Province { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * reportTime;
        [Export("reportTime")]
        string ReportTime { get; set; }

        // @property (nonatomic, strong) NSArray<AMapLocalDayWeatherForecast *> * casts;
        [Export("casts", ArgumentSemantic.Strong)]
        AMapLocalDayWeatherForecast[] Casts { get; set; }
    }

    // @interface AMapNearbyUserInfo : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapNearbyUserInfo
    {
        // @property (copy, nonatomic) NSString * userID;
        [Export("userID")]
        string UserID { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (assign, nonatomic) CGFloat distance;
        [Export("distance")]
        nfloat Distance { get; set; }

        // @property (assign, nonatomic) NSTimeInterval updatetime;
        [Export("updatetime")]
        double Updatetime { get; set; }
    }

    // @interface AMapTrafficEvaluation : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapTrafficEvaluation
    {
        // @property (copy, nonatomic) NSString * evaluationDescription;
        [Export("evaluationDescription")]
        string EvaluationDescription { get; set; }

        // @property (assign, nonatomic) NSInteger status;
        [Export("status")]
        nint Status { get; set; }

        // @property (copy, nonatomic) NSString * expedite;
        [Export("expedite")]
        string Expedite { get; set; }

        // @property (copy, nonatomic) NSString * congested;
        [Export("congested")]
        string Congested { get; set; }

        // @property (copy, nonatomic) NSString * blocked;
        [Export("blocked")]
        string Blocked { get; set; }

        // @property (copy, nonatomic) NSString * unknown;
        [Export("unknown")]
        string Unknown { get; set; }
    }

    // @interface AMapTrafficRoad : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapTrafficRoad
    {
        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (assign, nonatomic) NSInteger status;
        [Export("status")]
        nint Status { get; set; }

        // @property (copy, nonatomic) NSString * direction;
        [Export("direction")]
        string Direction { get; set; }

        // @property (assign, nonatomic) float angle;
        [Export("angle")]
        float Angle { get; set; }

        // @property (assign, nonatomic) float speed;
        [Export("speed")]
        float Speed { get; set; }

        // @property (copy, nonatomic) NSString * polyline;
        [Export("polyline")]
        string Polyline { get; set; }
    }

    // @interface AMapTrafficInfo : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapTrafficInfo
    {
        // @property (copy, nonatomic) NSString * statusDescription;
        [Export("statusDescription")]
        string StatusDescription { get; set; }

        // @property (nonatomic, strong) AMapTrafficEvaluation * evaluation;
        [Export("evaluation", ArgumentSemantic.Strong)]
        AMapTrafficEvaluation Evaluation { get; set; }

        // @property (nonatomic, strong) NSArray<AMapTrafficRoad *> * roads;
        [Export("roads", ArgumentSemantic.Strong)]
        AMapTrafficRoad[] Roads { get; set; }
    }

    // @interface AMapCloudImage : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapCloudImage
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) NSString * preurl;
        [Export("preurl")]
        string Preurl { get; set; }

        // @property (copy, nonatomic) NSString * url;
        [Export("url")]
        string Url { get; set; }
    }

    // @interface AMapCloudPOI : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapCloudPOI
    {
        // @property (assign, nonatomic) NSInteger uid;
        [Export("uid")]
        nint Uid { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * address;
        [Export("address")]
        string Address { get; set; }

        // @property (nonatomic, strong) NSDictionary * customFields;
        [Export("customFields", ArgumentSemantic.Strong)]
        NSDictionary CustomFields { get; set; }

        // @property (copy, nonatomic) NSString * createTime;
        [Export("createTime")]
        string CreateTime { get; set; }

        // @property (copy, nonatomic) NSString * updateTime;
        [Export("updateTime")]
        string UpdateTime { get; set; }

        // @property (assign, nonatomic) NSInteger distance;
        [Export("distance")]
        nint Distance { get; set; }

        // @property (nonatomic, strong) NSArray<AMapCloudImage *> * images;
        [Export("images", ArgumentSemantic.Strong)]
        AMapCloudImage[] Images { get; set; }
    }

    // @interface AMapPOISearchBaseRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapPOISearchBaseRequest
    {
        // @property (copy, nonatomic) NSString * types;
        [Export("types")]
        string Types { get; set; }

        // @property (assign, nonatomic) NSInteger sortrule;
        [Export("sortrule")]
        nint Sortrule { get; set; }

        // @property (assign, nonatomic) NSInteger offset;
        [Export("offset")]
        nint Offset { get; set; }

        // @property (assign, nonatomic) NSInteger page;
        [Export("page")]
        nint Page { get; set; }

        // @property (copy, nonatomic) NSString * building;
        [Export("building")]
        string Building { get; set; }

        // @property (assign, nonatomic) BOOL requireExtension;
        [Export("requireExtension")]
        bool RequireExtension { get; set; }

        // @property (assign, nonatomic) BOOL requireSubPOIs;
        [Export("requireSubPOIs")]
        bool RequireSubPOIs { get; set; }
    }

    // @interface AMapPOIIDSearchRequest : AMapPOISearchBaseRequest
    [BaseType(typeof(AMapPOISearchBaseRequest))]
    interface AMapPOIIDSearchRequest
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }
    }

    // @interface AMapPOIKeywordsSearchRequest : AMapPOISearchBaseRequest
    [BaseType(typeof(AMapPOISearchBaseRequest))]
    interface AMapPOIKeywordsSearchRequest
    {
        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (assign, nonatomic) BOOL cityLimit;
        [Export("cityLimit")]
        bool CityLimit { get; set; }

        // @property (nonatomic, strong) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Strong)]
        AMapGeoPoint Location { get; set; }
    }

    // @interface AMapPOIAroundSearchRequest : AMapPOISearchBaseRequest
    [BaseType(typeof(AMapPOISearchBaseRequest))]
    interface AMapPOIAroundSearchRequest
    {
        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (assign, nonatomic) NSInteger radius;
        [Export("radius")]
        nint Radius { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }
    }

    // @interface AMapPOIPolygonSearchRequest : AMapPOISearchBaseRequest
    [BaseType(typeof(AMapPOISearchBaseRequest))]
    interface AMapPOIPolygonSearchRequest
    {
        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }

        // @property (copy, nonatomic) AMapGeoPolygon * polygon;
        [Export("polygon", ArgumentSemantic.Copy)]
        AMapGeoPolygon Polygon { get; set; }
    }

    // @interface AMapPOISearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapPOISearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) AMapSuggestion * suggestion;
        [Export("suggestion", ArgumentSemantic.Strong)]
        AMapSuggestion Suggestion { get; set; }

        // @property (nonatomic, strong) NSArray<AMapPOI *> * pois;
        [Export("pois", ArgumentSemantic.Strong)]
        AMapPOI[] Pois { get; set; }
    }

    // @interface AMapRoutePOISearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRoutePOISearchRequest
    {
        // @property (copy, nonatomic) AMapGeoPoint * origin;
        [Export("origin", ArgumentSemantic.Copy)]
        AMapGeoPoint Origin { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * destination;
        [Export("destination", ArgumentSemantic.Copy)]
        AMapGeoPoint Destination { get; set; }

        // @property (assign, nonatomic) AMapRoutePOISearchType searchType;
        [Export("searchType", ArgumentSemantic.Assign)]
        AMapRoutePOISearchType SearchType { get; set; }

        // @property (assign, nonatomic) NSInteger strategy;
        [Export("strategy")]
        nint Strategy { get; set; }

        // @property (assign, nonatomic) NSInteger range;
        [Export("range")]
        nint Range { get; set; }

        // @property (nonatomic, strong) NSString * polylineStr;
        [Export("polylineStr", ArgumentSemantic.Strong)]
        string PolylineStr { get; set; }

        // @property (nonatomic, strong) NSArray<AMapGeoPoint *> * polyline;
        [Export("polyline", ArgumentSemantic.Strong)]
        AMapGeoPoint[] Polyline { get; set; }
    }

    // @interface AMapRoutePOISearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRoutePOISearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) NSArray<AMapRoutePOI *> * pois;
        [Export("pois", ArgumentSemantic.Strong)]
        AMapRoutePOI[] Pois { get; set; }
    }

    // @interface AMapInputTipsSearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapInputTipsSearchRequest
    {
        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * types;
        [Export("types")]
        string Types { get; set; }

        // @property (assign, nonatomic) BOOL cityLimit;
        [Export("cityLimit")]
        bool CityLimit { get; set; }

        // @property (copy, nonatomic) NSString * location;
        [Export("location")]
        string Location { get; set; }
    }

    // @interface AMapInputTipsSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapInputTipsSearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) NSArray<AMapTip *> * tips;
        [Export("tips", ArgumentSemantic.Strong)]
        AMapTip[] Tips { get; set; }
    }

    // @interface AMapGeocodeSearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapGeocodeSearchRequest
    {
        // @property (copy, nonatomic) NSString * address;
        [Export("address")]
        string Address { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }
    }

    // @interface AMapGeocodeSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapGeocodeSearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) NSArray<AMapGeocode *> * geocodes;
        [Export("geocodes", ArgumentSemantic.Strong)]
        AMapGeocode[] Geocodes { get; set; }
    }

    // @interface AMapReGeocodeSearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapReGeocodeSearchRequest
    {
        // @property (assign, nonatomic) BOOL requireExtension;
        [Export("requireExtension")]
        bool RequireExtension { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (assign, nonatomic) NSInteger radius;
        [Export("radius")]
        nint Radius { get; set; }

        // @property (copy, nonatomic) NSString * poitype;
        [Export("poitype")]
        string Poitype { get; set; }
    }

    // @interface AMapReGeocodeSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapReGeocodeSearchResponse
    {
        // @property (nonatomic, strong) AMapReGeocode * regeocode;
        [Export("regeocode", ArgumentSemantic.Strong)]
        AMapReGeocode Regeocode { get; set; }
    }

    // @interface AMapBusStopSearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapBusStopSearchRequest
    {
        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (assign, nonatomic) NSInteger offset;
        [Export("offset")]
        nint Offset { get; set; }

        // @property (assign, nonatomic) NSInteger page;
        [Export("page")]
        nint Page { get; set; }
    }

    // @interface AMapBusStopSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapBusStopSearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) AMapSuggestion * suggestion;
        [Export("suggestion", ArgumentSemantic.Strong)]
        AMapSuggestion Suggestion { get; set; }

        // @property (nonatomic, strong) NSArray<AMapBusStop *> * busstops;
        [Export("busstops", ArgumentSemantic.Strong)]
        AMapBusStop[] Busstops { get; set; }
    }

    // @interface AMapBusLineBaseSearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapBusLineBaseSearchRequest
    {
        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (assign, nonatomic) BOOL requireExtension;
        [Export("requireExtension")]
        bool RequireExtension { get; set; }

        // @property (assign, nonatomic) NSInteger offset;
        [Export("offset")]
        nint Offset { get; set; }

        // @property (assign, nonatomic) NSInteger page;
        [Export("page")]
        nint Page { get; set; }
    }

    // @interface AMapBusLineNameSearchRequest : AMapBusLineBaseSearchRequest
    [BaseType(typeof(AMapBusLineBaseSearchRequest))]
    interface AMapBusLineNameSearchRequest
    {
        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }
    }

    // @interface AMapBusLineIDSearchRequest : AMapBusLineBaseSearchRequest
    [BaseType(typeof(AMapBusLineBaseSearchRequest))]
    interface AMapBusLineIDSearchRequest
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }
    }

    // @interface AMapBusLineSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapBusLineSearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) AMapSuggestion * suggestion;
        [Export("suggestion", ArgumentSemantic.Strong)]
        AMapSuggestion Suggestion { get; set; }

        // @property (nonatomic, strong) NSArray<AMapBusLine *> * buslines;
        [Export("buslines", ArgumentSemantic.Strong)]
        AMapBusLine[] Buslines { get; set; }
    }

    // @interface AMapDistrictSearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapDistrictSearchRequest
    {
        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }

        // @property (assign, nonatomic) BOOL requireExtension;
        [Export("requireExtension")]
        bool RequireExtension { get; set; }

        // @property (assign, nonatomic) BOOL showBusinessArea __attribute__((deprecated("已废弃, from 5.3.0")));
        [Export("showBusinessArea")]
        bool ShowBusinessArea { get; set; }
    }

    // @interface AMapDistrictSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapDistrictSearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) NSArray<AMapDistrict *> * districts;
        [Export("districts", ArgumentSemantic.Strong)]
        AMapDistrict[] Districts { get; set; }
    }

    // @interface AMapRouteSearchBaseRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRouteSearchBaseRequest
    {
        // @property (copy, nonatomic) AMapGeoPoint * origin;
        [Export("origin", ArgumentSemantic.Copy)]
        AMapGeoPoint Origin { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * destination;
        [Export("destination", ArgumentSemantic.Copy)]
        AMapGeoPoint Destination { get; set; }
    }

    // @interface AMapDrivingRouteSearchRequest : AMapRouteSearchBaseRequest
    [BaseType(typeof(AMapRouteSearchBaseRequest))]
    interface AMapDrivingRouteSearchRequest
    {
        // @property (assign, nonatomic) NSInteger strategy;
        [Export("strategy")]
        nint Strategy { get; set; }

        // @property (copy, nonatomic) NSArray<AMapGeoPoint *> * waypoints;
        [Export("waypoints", ArgumentSemantic.Copy)]
        AMapGeoPoint[] Waypoints { get; set; }

        // @property (copy, nonatomic) NSArray<AMapGeoPolygon *> * avoidpolygons;
        [Export("avoidpolygons", ArgumentSemantic.Copy)]
        AMapGeoPolygon[] Avoidpolygons { get; set; }

        // @property (copy, nonatomic) NSString * avoidroad;
        [Export("avoidroad")]
        string Avoidroad { get; set; }

        // @property (copy, nonatomic) NSString * originId;
        [Export("originId")]
        string OriginId { get; set; }

        // @property (copy, nonatomic) NSString * destinationId;
        [Export("destinationId")]
        string DestinationId { get; set; }

        // @property (copy, nonatomic) NSString * origintype;
        [Export("origintype")]
        string Origintype { get; set; }

        // @property (copy, nonatomic) NSString * destinationtype;
        [Export("destinationtype")]
        string Destinationtype { get; set; }

        // @property (assign, nonatomic) BOOL requireExtension;
        [Export("requireExtension")]
        bool RequireExtension { get; set; }

        // @property (copy, nonatomic) NSString * plateProvince;
        [Export("plateProvince")]
        string PlateProvince { get; set; }

        // @property (copy, nonatomic) NSString * plateNumber;
        [Export("plateNumber")]
        string PlateNumber { get; set; }
    }

    // @interface AMapWalkingRouteSearchRequest : AMapRouteSearchBaseRequest
    [BaseType(typeof(AMapRouteSearchBaseRequest))]
    interface AMapWalkingRouteSearchRequest
    {
        // @property (assign, nonatomic) NSInteger multipath __attribute__((deprecated("已废弃, from 5.0.0")));
        [Export("multipath")]
        nint Multipath { get; set; }
    }

    // @interface AMapTransitRouteSearchRequest : AMapRouteSearchBaseRequest
    [BaseType(typeof(AMapRouteSearchBaseRequest))]
    interface AMapTransitRouteSearchRequest
    {
        // @property (assign, nonatomic) NSInteger strategy;
        [Export("strategy")]
        nint Strategy { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * destinationCity;
        [Export("destinationCity")]
        string DestinationCity { get; set; }

        // @property (assign, nonatomic) BOOL nightflag;
        [Export("nightflag")]
        bool Nightflag { get; set; }

        // @property (assign, nonatomic) BOOL requireExtension;
        [Export("requireExtension")]
        bool RequireExtension { get; set; }
    }

    // @interface AMapRidingRouteSearchRequest : AMapRouteSearchBaseRequest
    [BaseType(typeof(AMapRouteSearchBaseRequest))]
    interface AMapRidingRouteSearchRequest
    {
        // @property (assign, nonatomic) NSInteger type __attribute__((deprecated("已废弃, from 5.0.0")));
        [Export("type")]
        nint Type { get; set; }
    }

    // @interface AMapRouteSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRouteSearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) AMapRoute * route;
        [Export("route", ArgumentSemantic.Strong)]
        AMapRoute Route { get; set; }
    }

    // @interface AMapRidingRouteSearchResponse : AMapRouteSearchResponse
    [BaseType(typeof(AMapRouteSearchResponse))]
    interface AMapRidingRouteSearchResponse
    {
    }

    // @interface AMapWeatherSearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapWeatherSearchRequest
    {
        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }

        // @property (assign, nonatomic) AMapWeatherType type;
        [Export("type", ArgumentSemantic.Assign)]
        AMapWeatherType Type { get; set; }
    }

    // @interface AMapWeatherSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapWeatherSearchResponse
    {
        // @property (nonatomic, strong) NSArray<AMapLocalWeatherLive *> * lives;
        [Export("lives", ArgumentSemantic.Strong)]
        AMapLocalWeatherLive[] Lives { get; set; }

        // @property (nonatomic, strong) NSArray<AMapLocalWeatherForecast *> * forecasts;
        [Export("forecasts", ArgumentSemantic.Strong)]
        AMapLocalWeatherForecast[] Forecasts { get; set; }
    }

    // @interface AMapRoadTrafficSearchBaseRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRoadTrafficSearchBaseRequest
    {
        // @property (assign, nonatomic) NSInteger level;
        [Export("level")]
        nint Level { get; set; }

        // @property (assign, nonatomic) BOOL requireExtension;
        [Export("requireExtension")]
        bool RequireExtension { get; set; }
    }

    // @interface AMapRoadTrafficSearchRequest : AMapRoadTrafficSearchBaseRequest
    [BaseType(typeof(AMapRoadTrafficSearchBaseRequest))]
    interface AMapRoadTrafficSearchRequest
    {
        // @property (copy, nonatomic) NSString * roadName;
        [Export("roadName")]
        string RoadName { get; set; }

        // @property (copy, nonatomic) NSString * adcode;
        [Export("adcode")]
        string Adcode { get; set; }
    }

    // @interface AMapRoadTrafficCircleSearchRequest : AMapRoadTrafficSearchBaseRequest
    [BaseType(typeof(AMapRoadTrafficSearchBaseRequest))]
    interface AMapRoadTrafficCircleSearchRequest
    {
        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (assign, nonatomic) NSInteger radius;
        [Export("radius")]
        nint Radius { get; set; }
    }

    // @interface AMapRoadTrafficSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapRoadTrafficSearchResponse
    {
        // @property (nonatomic, strong) AMapTrafficInfo * trafficInfo;
        [Export("trafficInfo", ArgumentSemantic.Strong)]
        AMapTrafficInfo TrafficInfo { get; set; }
    }

    // @interface AMapNearbySearchRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapNearbySearchRequest
    {
        // @property (copy, nonatomic) AMapGeoPoint * center;
        [Export("center", ArgumentSemantic.Copy)]
        AMapGeoPoint Center { get; set; }

        // @property (assign, nonatomic) NSInteger radius;
        [Export("radius")]
        nint Radius { get; set; }

        // @property (assign, nonatomic) AMapNearbySearchType searchType;
        [Export("searchType", ArgumentSemantic.Assign)]
        AMapNearbySearchType SearchType { get; set; }

        // @property (assign, nonatomic) NSInteger timeRange;
        [Export("timeRange")]
        nint TimeRange { get; set; }

        // @property (assign, nonatomic) NSInteger limit;
        [Export("limit")]
        nint Limit { get; set; }
    }

    // @interface AMapNearbySearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapNearbySearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) NSArray<AMapNearbyUserInfo *> * infos;
        [Export("infos", ArgumentSemantic.Strong)]
        AMapNearbyUserInfo[] Infos { get; set; }
    }

    // @interface AMapCloudSearchBaseRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapCloudSearchBaseRequest
    {
        // @property (copy, nonatomic) NSString * tableID;
        [Export("tableID")]
        string TableID { get; set; }

        // @property (nonatomic, strong) NSArray<NSString *> * filter;
        [Export("filter", ArgumentSemantic.Strong)]
        string[] Filter { get; set; }

        // @property (copy, nonatomic) NSString * sortFields;
        [Export("sortFields")]
        string SortFields { get; set; }

        // @property (assign, nonatomic) AMapCloudSortType sortType;
        [Export("sortType", ArgumentSemantic.Assign)]
        AMapCloudSortType SortType { get; set; }

        // @property (assign, nonatomic) NSInteger offset;
        [Export("offset")]
        nint Offset { get; set; }

        // @property (assign, nonatomic) NSInteger page;
        [Export("page")]
        nint Page { get; set; }
    }

    // @interface AMapCloudPOIAroundSearchRequest : AMapCloudSearchBaseRequest
    [BaseType(typeof(AMapCloudSearchBaseRequest))]
    interface AMapCloudPOIAroundSearchRequest
    {
        // @property (copy, nonatomic) AMapGeoPoint * center;
        [Export("center", ArgumentSemantic.Copy)]
        AMapGeoPoint Center { get; set; }

        // @property (assign, nonatomic) NSInteger radius;
        [Export("radius")]
        nint Radius { get; set; }

        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }
    }

    // @interface AMapCloudPOIPolygonSearchRequest : AMapCloudSearchBaseRequest
    [BaseType(typeof(AMapCloudSearchBaseRequest))]
    interface AMapCloudPOIPolygonSearchRequest
    {
        // @property (copy, nonatomic) AMapGeoPolygon * polygon;
        [Export("polygon", ArgumentSemantic.Copy)]
        AMapGeoPolygon Polygon { get; set; }

        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }
    }

    // @interface AMapCloudPOIIDSearchRequest : AMapCloudSearchBaseRequest
    [BaseType(typeof(AMapCloudSearchBaseRequest))]
    interface AMapCloudPOIIDSearchRequest
    {
        // @property (assign, nonatomic) NSInteger uid;
        [Export("uid")]
        nint Uid { get; set; }
    }

    // @interface AMapCloudPOILocalSearchRequest : AMapCloudSearchBaseRequest
    [BaseType(typeof(AMapCloudSearchBaseRequest))]
    interface AMapCloudPOILocalSearchRequest
    {
        // @property (copy, nonatomic) NSString * keywords;
        [Export("keywords")]
        string Keywords { get; set; }

        // @property (copy, nonatomic) NSString * city;
        [Export("city")]
        string City { get; set; }
    }

    // @interface AMapCloudPOISearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapCloudPOISearchResponse
    {
        // @property (assign, nonatomic) NSInteger count;
        [Export("count")]
        nint Count { get; set; }

        // @property (nonatomic, strong) NSArray<AMapCloudPOI *> * POIs;
        [Export("POIs", ArgumentSemantic.Strong)]
        AMapCloudPOI[] POIs { get; set; }
    }

    // @interface AMapShareSearchBaseRequest : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapShareSearchBaseRequest
    {
    }

    // @interface AMapLocationShareSearchRequest : AMapShareSearchBaseRequest
    [BaseType(typeof(AMapShareSearchBaseRequest))]
    interface AMapLocationShareSearchRequest
    {
        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }
    }

    // @interface AMapPOIShareSearchRequest : AMapShareSearchBaseRequest
    [BaseType(typeof(AMapShareSearchBaseRequest))]
    interface AMapPOIShareSearchRequest
    {
        // @property (copy, nonatomic) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * location;
        [Export("location", ArgumentSemantic.Copy)]
        AMapGeoPoint Location { get; set; }

        // @property (copy, nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * address;
        [Export("address")]
        string Address { get; set; }
    }

    // @interface AMapRouteShareSearchRequest : AMapShareSearchBaseRequest
    [BaseType(typeof(AMapShareSearchBaseRequest))]
    interface AMapRouteShareSearchRequest
    {
        // @property (assign, nonatomic) NSInteger strategy;
        [Export("strategy")]
        nint Strategy { get; set; }

        // @property (assign, nonatomic) NSInteger type;
        [Export("type")]
        nint Type { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * startCoordinate;
        [Export("startCoordinate", ArgumentSemantic.Copy)]
        AMapGeoPoint StartCoordinate { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * destinationCoordinate;
        [Export("destinationCoordinate", ArgumentSemantic.Copy)]
        AMapGeoPoint DestinationCoordinate { get; set; }

        // @property (copy, nonatomic) NSString * startName;
        [Export("startName")]
        string StartName { get; set; }

        // @property (copy, nonatomic) NSString * destinationName;
        [Export("destinationName")]
        string DestinationName { get; set; }
    }

    // @interface AMapNavigationShareSearchRequest : AMapShareSearchBaseRequest
    [BaseType(typeof(AMapShareSearchBaseRequest))]
    interface AMapNavigationShareSearchRequest
    {
        // @property (assign, nonatomic) NSInteger strategy;
        [Export("strategy")]
        nint Strategy { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * startCoordinate;
        [Export("startCoordinate", ArgumentSemantic.Copy)]
        AMapGeoPoint StartCoordinate { get; set; }

        // @property (copy, nonatomic) AMapGeoPoint * destinationCoordinate;
        [Export("destinationCoordinate", ArgumentSemantic.Copy)]
        AMapGeoPoint DestinationCoordinate { get; set; }
    }

    // @interface AMapShareSearchResponse : AMapSearchObject
    [BaseType(typeof(AMapSearchObject))]
    interface AMapShareSearchResponse
    {
        // @property (copy, nonatomic) NSString * shareURL;
        [Export("shareURL")]
        string ShareURL { get; set; }
    }

    // @interface AMapSearchAPI : NSObject
    [BaseType(typeof(NSObject))]
    interface AMapSearchAPI
    {
        [Wrap("WeakDelegate")]
        AMapSearchDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AMapSearchDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) NSInteger timeout;
        [Export("timeout")]
        nint Timeout { get; set; }

        // @property (assign, nonatomic) AMapSearchLanguage language;
        [Export("language", ArgumentSemantic.Assign)]
        AMapSearchLanguage Language { get; set; }

        // -(void)cancelAllRequests;
        [Export("cancelAllRequests")]
        void CancelAllRequests();

        // -(void)AMapPOIIDSearch:(AMapPOIIDSearchRequest *)request;
        [Export("AMapPOIIDSearch:")]
        void AMapPOIIDSearch(AMapPOIIDSearchRequest request);

        // -(void)AMapPOIKeywordsSearch:(AMapPOIKeywordsSearchRequest *)request;
        [Export("AMapPOIKeywordsSearch:")]
        void AMapPOIKeywordsSearch(AMapPOIKeywordsSearchRequest request);

        // -(void)AMapPOIAroundSearch:(AMapPOIAroundSearchRequest *)request;
        [Export("AMapPOIAroundSearch:")]
        void AMapPOIAroundSearch(AMapPOIAroundSearchRequest request);

        // -(void)AMapPOIPolygonSearch:(AMapPOIPolygonSearchRequest *)request;
        [Export("AMapPOIPolygonSearch:")]
        void AMapPOIPolygonSearch(AMapPOIPolygonSearchRequest request);

        // -(void)AMapRoutePOISearch:(AMapRoutePOISearchRequest *)request;
        [Export("AMapRoutePOISearch:")]
        void AMapRoutePOISearch(AMapRoutePOISearchRequest request);

        // -(void)AMapGeocodeSearch:(AMapGeocodeSearchRequest *)request;
        [Export("AMapGeocodeSearch:")]
        void AMapGeocodeSearch(AMapGeocodeSearchRequest request);

        // -(void)AMapReGoecodeSearch:(AMapReGeocodeSearchRequest *)request;
        [Export("AMapReGoecodeSearch:")]
        void AMapReGoecodeSearch(AMapReGeocodeSearchRequest request);

        // -(void)AMapInputTipsSearch:(AMapInputTipsSearchRequest *)request;
        [Export("AMapInputTipsSearch:")]
        void AMapInputTipsSearch(AMapInputTipsSearchRequest request);

        // -(void)AMapBusStopSearch:(AMapBusStopSearchRequest *)request;
        [Export("AMapBusStopSearch:")]
        void AMapBusStopSearch(AMapBusStopSearchRequest request);

        // -(void)AMapBusLineIDSearch:(AMapBusLineIDSearchRequest *)request;
        [Export("AMapBusLineIDSearch:")]
        void AMapBusLineIDSearch(AMapBusLineIDSearchRequest request);

        // -(void)AMapBusLineNameSearch:(AMapBusLineNameSearchRequest *)request;
        [Export("AMapBusLineNameSearch:")]
        void AMapBusLineNameSearch(AMapBusLineNameSearchRequest request);

        // -(void)AMapDistrictSearch:(AMapDistrictSearchRequest *)request;
        [Export("AMapDistrictSearch:")]
        void AMapDistrictSearch(AMapDistrictSearchRequest request);

        // -(void)AMapDrivingRouteSearch:(AMapDrivingRouteSearchRequest *)request;
        [Export("AMapDrivingRouteSearch:")]
        void AMapDrivingRouteSearch(AMapDrivingRouteSearchRequest request);

        // -(void)AMapWalkingRouteSearch:(AMapWalkingRouteSearchRequest *)request;
        [Export("AMapWalkingRouteSearch:")]
        void AMapWalkingRouteSearch(AMapWalkingRouteSearchRequest request);

        // -(void)AMapTransitRouteSearch:(AMapTransitRouteSearchRequest *)request;
        [Export("AMapTransitRouteSearch:")]
        void AMapTransitRouteSearch(AMapTransitRouteSearchRequest request);

        // -(void)AMapRidingRouteSearch:(AMapRidingRouteSearchRequest *)request;
        [Export("AMapRidingRouteSearch:")]
        void AMapRidingRouteSearch(AMapRidingRouteSearchRequest request);

        // -(void)AMapWeatherSearch:(AMapWeatherSearchRequest *)request;
        [Export("AMapWeatherSearch:")]
        void AMapWeatherSearch(AMapWeatherSearchRequest request);

        // -(void)AMapRoadTrafficSearch:(AMapRoadTrafficSearchRequest *)request;
        [Export("AMapRoadTrafficSearch:")]
        void AMapRoadTrafficSearch(AMapRoadTrafficSearchRequest request);

        // -(void)AMapRoadTrafficCircleSearch:(AMapRoadTrafficCircleSearchRequest *)request;
        [Export("AMapRoadTrafficCircleSearch:")]
        void AMapRoadTrafficCircleSearch(AMapRoadTrafficCircleSearchRequest request);

        // -(void)AMapNearbySearch:(AMapNearbySearchRequest *)request;
        [Export("AMapNearbySearch:")]
        void AMapNearbySearch(AMapNearbySearchRequest request);

        // -(void)AMapCloudPOIAroundSearch:(AMapCloudPOIAroundSearchRequest *)request;
        [Export("AMapCloudPOIAroundSearch:")]
        void AMapCloudPOIAroundSearch(AMapCloudPOIAroundSearchRequest request);

        // -(void)AMapCloudPOIPolygonSearch:(AMapCloudPOIPolygonSearchRequest *)request;
        [Export("AMapCloudPOIPolygonSearch:")]
        void AMapCloudPOIPolygonSearch(AMapCloudPOIPolygonSearchRequest request);

        // -(void)AMapCloudPOIIDSearch:(AMapCloudPOIIDSearchRequest *)request;
        [Export("AMapCloudPOIIDSearch:")]
        void AMapCloudPOIIDSearch(AMapCloudPOIIDSearchRequest request);

        // -(void)AMapCloudPOILocalSearch:(AMapCloudPOILocalSearchRequest *)request;
        [Export("AMapCloudPOILocalSearch:")]
        void AMapCloudPOILocalSearch(AMapCloudPOILocalSearchRequest request);

        // -(void)AMapLocationShareSearch:(AMapLocationShareSearchRequest *)request;
        [Export("AMapLocationShareSearch:")]
        void AMapLocationShareSearch(AMapLocationShareSearchRequest request);

        // -(void)AMapPOIShareSearch:(AMapPOIShareSearchRequest *)request;
        [Export("AMapPOIShareSearch:")]
        void AMapPOIShareSearch(AMapPOIShareSearchRequest request);

        // -(void)AMapRouteShareSearch:(AMapRouteShareSearchRequest *)request;
        [Export("AMapRouteShareSearch:")]
        void AMapRouteShareSearch(AMapRouteShareSearchRequest request);

        // -(void)AMapNavigationShareSearch:(AMapNavigationShareSearchRequest *)request;
        [Export("AMapNavigationShareSearch:")]
        void AMapNavigationShareSearch(AMapNavigationShareSearchRequest request);
    }

    // @protocol AMapSearchDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AMapSearchDelegate
    {
        // @optional -(void)AMapSearchRequest:(id)request didFailWithError:(NSError *)error;
        [Export("AMapSearchRequest:didFailWithError:")]
        void AMapSearchRequest(NSObject request, NSError error);

        // @optional -(void)onPOISearchDone:(AMapPOISearchBaseRequest *)request response:(AMapPOISearchResponse *)response;
        [Export("onPOISearchDone:response:")]
        void OnPOISearchDone(AMapPOISearchBaseRequest request, AMapPOISearchResponse response);

        // @optional -(void)onRoutePOISearchDone:(AMapRoutePOISearchRequest *)request response:(AMapRoutePOISearchResponse *)response;
        [Export("onRoutePOISearchDone:response:")]
        void OnRoutePOISearchDone(AMapRoutePOISearchRequest request, AMapRoutePOISearchResponse response);

        // @optional -(void)onGeocodeSearchDone:(AMapGeocodeSearchRequest *)request response:(AMapGeocodeSearchResponse *)response;
        [Export("onGeocodeSearchDone:response:")]
        void OnGeocodeSearchDone(AMapGeocodeSearchRequest request, AMapGeocodeSearchResponse response);

        // @optional -(void)onReGeocodeSearchDone:(AMapReGeocodeSearchRequest *)request response:(AMapReGeocodeSearchResponse *)response;
        [Export("onReGeocodeSearchDone:response:")]
        void OnReGeocodeSearchDone(AMapReGeocodeSearchRequest request, AMapReGeocodeSearchResponse response);

        // @optional -(void)onInputTipsSearchDone:(AMapInputTipsSearchRequest *)request response:(AMapInputTipsSearchResponse *)response;
        [Export("onInputTipsSearchDone:response:")]
        void OnInputTipsSearchDone(AMapInputTipsSearchRequest request, AMapInputTipsSearchResponse response);

        // @optional -(void)onBusStopSearchDone:(AMapBusStopSearchRequest *)request response:(AMapBusStopSearchResponse *)response;
        [Export("onBusStopSearchDone:response:")]
        void OnBusStopSearchDone(AMapBusStopSearchRequest request, AMapBusStopSearchResponse response);

        // @optional -(void)onBusLineSearchDone:(AMapBusLineBaseSearchRequest *)request response:(AMapBusLineSearchResponse *)response;
        [Export("onBusLineSearchDone:response:")]
        void OnBusLineSearchDone(AMapBusLineBaseSearchRequest request, AMapBusLineSearchResponse response);

        // @optional -(void)onDistrictSearchDone:(AMapDistrictSearchRequest *)request response:(AMapDistrictSearchResponse *)response;
        [Export("onDistrictSearchDone:response:")]
        void OnDistrictSearchDone(AMapDistrictSearchRequest request, AMapDistrictSearchResponse response);

        // @optional -(void)onRouteSearchDone:(AMapRouteSearchBaseRequest *)request response:(AMapRouteSearchResponse *)response;
        [Export("onRouteSearchDone:response:")]
        void OnRouteSearchDone(AMapRouteSearchBaseRequest request, AMapRouteSearchResponse response);

        // @optional -(void)onWeatherSearchDone:(AMapWeatherSearchRequest *)request response:(AMapWeatherSearchResponse *)response;
        [Export("onWeatherSearchDone:response:")]
        void OnWeatherSearchDone(AMapWeatherSearchRequest request, AMapWeatherSearchResponse response);

        // @optional -(void)onRoadTrafficSearchDone:(AMapRoadTrafficSearchBaseRequest *)request response:(AMapRoadTrafficSearchResponse *)response;
        [Export("onRoadTrafficSearchDone:response:")]
        void OnRoadTrafficSearchDone(AMapRoadTrafficSearchBaseRequest request, AMapRoadTrafficSearchResponse response);

        // @optional -(void)onNearbySearchDone:(AMapNearbySearchRequest *)request response:(AMapNearbySearchResponse *)response;
        [Export("onNearbySearchDone:response:")]
        void OnNearbySearchDone(AMapNearbySearchRequest request, AMapNearbySearchResponse response);

        // @optional -(void)onCloudSearchDone:(AMapCloudSearchBaseRequest *)request response:(AMapCloudPOISearchResponse *)response;
        [Export("onCloudSearchDone:response:")]
        void OnCloudSearchDone(AMapCloudSearchBaseRequest request, AMapCloudPOISearchResponse response);

        // @optional -(void)onShareSearchDone:(AMapShareSearchBaseRequest *)request response:(AMapShareSearchResponse *)response;
        [Export("onShareSearchDone:response:")]
        void OnShareSearchDone(AMapShareSearchBaseRequest request, AMapShareSearchResponse response);
    }

    // @interface AMapNearbyUploadInfo : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface AMapNearbyUploadInfo : INSCopying
    {
        // @property (copy, nonatomic) NSString * userID;
        [Export("userID")]
        string UserID { get; set; }

        // @property (assign, nonatomic) AMapSearchCoordinateType coordinateType;
        [Export("coordinateType", ArgumentSemantic.Assign)]
        AMapSearchCoordinateType CoordinateType { get; set; }

        // @property (assign, nonatomic) CLLocationCoordinate2D coordinate;
        [Export("coordinate", ArgumentSemantic.Assign)]
        CLLocationCoordinate2D Coordinate { get; set; }
    }

    // @protocol AMapNearbySearchManagerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AMapNearbySearchManagerDelegate
    {
        // @optional -(AMapNearbyUploadInfo *)nearbyInfoForUploading:(AMapNearbySearchManager *)manager;
        [Export("nearbyInfoForUploading:")]
        AMapNearbyUploadInfo NearbyInfoForUploading(AMapNearbySearchManager manager);

        // @optional -(void)onNearbyInfoUploadedWithError:(NSError *)error;
        [Export("onNearbyInfoUploadedWithError:")]
        void OnNearbyInfoUploadedWithError(NSError error);

        // @optional -(void)onUserInfoClearedWithError:(NSError *)error;
        [Export("onUserInfoClearedWithError:")]
        void OnUserInfoClearedWithError(NSError error);
    }

    // @interface AMapNearbySearchManager : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface AMapNearbySearchManager
    {
        // @property (assign, nonatomic) NSTimeInterval uploadTimeInterval;
        [Export("uploadTimeInterval")]
        double UploadTimeInterval { get; set; }

        [Wrap("WeakDelegate")]
        AMapNearbySearchManagerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<AMapNearbySearchManagerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) BOOL isAutoUploading;
        [Export("isAutoUploading")]
        bool IsAutoUploading { get; }

        // +(instancetype)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        AMapNearbySearchManager SharedInstance();

        // -(void)startAutoUploadNearbyInfo;
        [Export("startAutoUploadNearbyInfo")]
        void StartAutoUploadNearbyInfo();

        // -(void)stopAutoUploadNearbyInfo;
        [Export("stopAutoUploadNearbyInfo")]
        void StopAutoUploadNearbyInfo();

        // -(BOOL)uploadNearbyInfo:(AMapNearbyUploadInfo *)info;
        [Export("uploadNearbyInfo:")]
        bool UploadNearbyInfo(AMapNearbyUploadInfo info);

        // -(BOOL)clearUserInfoWithID:(NSString *)userID;
        [Export("clearUserInfoWithID:")]
        bool ClearUserInfoWithID(string userID);
    }

    

}

