# How to create a custom geocode panel


This example demonstrates how to create a custom geocode panel.


<h3>Description</h3>

<p>&nbsp;For this, do the following.<br />1. Create a&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapBingGeocodeDataProvidertopic">BingGeocodeDataProvider</a> object and assign it to the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapInformationLayer_DataProvidertopic">InformationLayer.DataProvider</a> property. Specify the object's&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingMapDataProviderBase_BingKeytopic">BingKey</a> property.<br />2. Customize the custom geocode panel. In this example, the panel includes two text edits (for the latitude and longitude) and the Search button.<br />3. Call the&nbsp;<a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingGeocodeDataProvider_RequestLocationInformationtopic">BingGeocodeDataProvider.RequestLocationInformation</a> method to make a location information request. In this example, the method is called in the Search button click event handler.</p>

<br/>


