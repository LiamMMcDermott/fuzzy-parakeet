# NOTE: This is not even close to being finished.
# fuzzy-parakeet
# 
Postcode Property Geolocation for Umbraco using the amazing <a href="http://postcodes.io/">postcodes.io</a>
# Info
Idea for a new Umbraco package:

1. Postcode field on Node
2. Hooks into the Umbraco OnSaved event - Calls Postcodes.io to convert to LatLon and saves read-only property
TODO:
Maps property to render location for node. 
