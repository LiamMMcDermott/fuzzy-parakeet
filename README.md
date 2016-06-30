# fuzzy-parakeet
# NOTE: Needs work.
Postcode Property Geolocation for Umbraco using the amazing <a href="http://postcodes.io/">postcodes.io</a>
# Info
Idea for a new Umbraco package 

1. Postcode field on Node
2. Hooks into the Umbraco OnSaved event - Calls Postcodes.io to convert to LatLon and saves read-only property
3. TODO:Maps property to render location for node, manage document type properties for flexibility

Needs polished and need to add unit tests.
