# Park Lookup API

#### By Joseph Wilfong

## Technologies Used

* _C#_
* _.NET SDK_
* _MySQL_
* _MySQL Workbench_
* _Entity Framework Core_
* _Swagger UI_
* _Postman_




Description
-----------

_The Park Lookup API provides information about national parks and the states they are located in. It allows users to retrieve data about different national parks, search for parks based on specific criteria, and access details such as park names, descriptions, and states. It performs CRUD (Create, Read, Update, Delete) operations on park data._

Features
--------

* Retrieve a list of national parks along with their associated states.
* Search for parks based on park names, states, or descriptions.
* Access detailed information about a specific park by its ID.
* Add new national parks to the database.
* Update existing park information.
* Delete parks from the database.

Setup/Installation Requirements
------------------------------


Endpoints
---------

* The API exposes the following endpoints:

* 'GET /api/{v1,v2}/parks': Retrieves a list of all national parks.

Example Request: 

```
    {
        "parkId": 1,
        "parkName": "Acadia",
        "state": "Maine",
        "description": "Acadia National Park is an American national park located in the state of Maine, southwest of Bar Harbor. The park preserves about half of Mount Desert Island, many adjacent smaller islands, and part of the Schoodic Peninsula on the coast of Maine."
    },
    {
        "parkId": 2,
        "parkName": "Arches",
        "state": "Utah",
        "description": "Arches National Park is a national park in eastern Utah, United States. The park is adjacent to the Colorado River, 4 miles north of Moab, Utah. More than 2,000 natural sandstone arches are located in the park, including the well-known Delicate Arch, as well as a variety of unique geological resources and formations."
    },
    {
        "parkId": 3,
        "parkName": "Badlands",
        "state": "South Dakota",
        "description": "Badlands National Park is an American national park located in southwestern South Dakota. The park protects 242,756 acres of sharply eroded buttes and pinnacles, along with the largest undisturbed mixed grass prairie in the United States."
    },
```
* 'GET /api/{v1,v2}/parks/{id}': Retrieves detailed information about a specific park by its ID.

Example Request: 

```
    {
        "parkId": 1,
        "parkName": "Acadia",
        "state": "Maine",
        "description": "Acadia National Park is an American national park located in the state of Maine, southwest of Bar Harbor. The park preserves about half of Mount Desert Island, many adjacent smaller islands, and part of the Schoodic Peninsula on the coast of Maine."
    }
```
* 'POST /api/{v1,v2}/parks': Adds a new national park to the database.

Postman:

Create a new POST request in Postman and set the request URL to http://localhost:5000/api/v1/parks. Then, select the Body tab and choose the raw option. Set the format to JSON and enter the following request body replacing string with the appropriate values:
```
    {
        "parkName": "string",
        "state": "string",
        "description": "string"
    }
```
* 'PUT /api/{v1,v2}/parks/{id}': Updates information for a specific park.

Postman:

Create a new PUT request in Postman and set the request URL to http://localhost:5000/api/v1/parks/1. Then, select the Body tab and choose the raw option. Set the format to JSON and enter the following request body replacing string with the appropriate values to update the park:
```
    {
        "parkName": "string",
        "state": "string",
        "description": "string"
    }
```
* 'DELETE /api/{v1,v2}/parks/{id}': Deletes a national park from the database.

Postman:

Create a new DELETE request in Postman and set the request URL to http://localhost:5000/api/v1/parks/1. 
Press send and you will receive a 204 No Content response if the park was successfully deleted.

Optional Query Parameters
-------------------------

The National Parks Lookup API supports the following optional query parameters for searching and filtering parks:

| Parameter   | Type        | Required | Description |
| ----------- | ----------- | -------- | ----------- |
| parkName    | String      | Yes       | Filters parks by the park name. |
| state       | String      | Yes       | Filters parks by the state. |
| description | String      | Yes       | Filters parks by the description. |
| pageNumber  | Int         | No       | Specifies the page number for paginated results. |
| pageSize    | Int         | No       | Specifies the number of parks to include per page. |


Links
-----

[This is the link to the Github repository](https://github.com/jcarenza67/Parks-Lookup.Solution) 


***_Please contact me at josephwilfong91@gmail.com if you have any questions, ideas, or concerns._***


Known Bugs
----------

* _V1 and V2 works, V2 just does ***not*** work with authentication yet_

## License


_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._

_Copyright (c) _2023_ _Joseph Wilfong_