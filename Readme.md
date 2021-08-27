<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576256/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T188910)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[Form1.cs](./CS/MapControl_GeocodePanel/Form1.cs) (VB: [Form1.vb](./VB/MapControl_GeocodePanel/Form1.vb))**
<!-- default file list end -->
# How to create a custom geocode panel


This example demonstrates how to create a custom geocode panel.


<h3>Description</h3>

For this, do the following.<br>1. Create a&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBingGeocodeDataProvidertopic">BingGeocodeDataProvider</a> object and assign it to the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationLayer_DataProvidertopic">InformationLayer.DataProvider</a> property. Specify the object's&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingMapDataProviderBase_BingKeytopic">BingKey</a> property.<br>2. Customize the custom geocode panel. In this example, the panel includes two text edits (for the latitude and longitude) and the Search button.<br>3. Call the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic">BingGeocodeDataProvider.RequestLocationInformation</a> method to make a location information request. In this example, the method is called in the Search button click event handler.

<br/>


