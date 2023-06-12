# Park Lookup API

#### By Joseph Wilfong

Table of Contents
-----------------
* [Technologies Used](#technologies-used)
* [Description](#description)
* [Features](#features)
* [Setup/Installation Requirements](#setupinstallation-requirements)
* [Endpoints](#endpoints)
* [Optional Query Parameters](#optional-query-parameters)
* [Links](#links)
* [Known Bugs](#known-bugs)
* [License](#license)

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

Setup Requirements
------------------

To set up the Park Lookup API project on your local machine, please ensure you have the following installed:

* .Net 5.0 SDK
* MySQL Server and MySQL Workbench
* Postman

Installation
------------

* _Clone the repository from GitHub using the following command:_
```
git clone https://github.com/jcarenza67/Parks-Lookup.Solution.git
```

* _Navigate to the project directory:
```
cd Parks-Lookup.Solution/ParksApi
```

* _Create a file named "appsettings.json" in the ParksApi directory with the following contents._
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=park_api;uid=YOUR_USERNAME;pwd=YOUR_PASSWORD;"
  }
}
```
* _Replace YOUR_USERNAME and YOUR_PASSWORD with the username and password you selected when installing MySQL Server._

* _Run the following commands to install the required dependencies and start the API:_
```
dotnet restore
dotnet build
dotnet run
```
* _The API will be accessible at http://localhost:5000._

* _To view the Swagger UI documentation for the API, navigate to http://localhost:5000/swagger in your web browser._

Endpoints
---------

* The API exposes the following endpoints:
```
* 'GET /api/{v1,v2}/parks
```
* _Retrieves a list of all national parks._
JSON
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
***
```
* 'GET /api/{v1,v2}/parks/{id}
```
* _Retrieves detailed information about a specific park._
JSON
Example Request: 

```
    {
        "parkId": 1,
        "parkName": "Acadia",
        "state": "Maine",
        "description": "Acadia National Park is an American national park located in the state of Maine, southwest of Bar Harbor. The park preserves about half of Mount Desert Island, many adjacent smaller islands, and part of the Schoodic Peninsula on the coast of Maine."
    }
```
***
Postman Examples:
-----------------

***Create a new park***:

* For this operation, set up a new POST request in Postman with the request URL set to http://localhost:5000/api/v1,v2/parks and replace the strings with desired values.
```
    {
        "parkName": "string",
        "state": "string",
        "description": "string"
    }
```
***

***Update an existing park***:

* For this operation, set up a new PUT request in Postman with the request URL set to http://localhost:5000/api/v1,v2/parks/{id} and replace the strings with desired values.
```
    {
        "parkName": "string",
        "state": "string",
        "description": "string"
    }
```
***

***Delete a park***:

Create a new DELETE request in Postman and set the request URL to http://localhost:5000/api/v1,v2/parks/{id}. 
Press send and you will receive a 204 No Content response if the park was successfully deleted.
***

***See a random park***:

Create a new GET request in Postman and set the request URL to http://localhost:5000/api/v1,v2/parks/random.
***
***Please note that the endpoint URLs may vary depending on the version of the API you're using (v1 or v2).*** ***Comments in the controllers indicate which endpoints are available for each version.***
***
Pagenation Endpoints
--------------------
***v1 does not have pagination***

* The API also supports pagination for the GET /api/v2/parks endpoint. The following endpoints are available for paginated results:

* 'GET api/v2/parks?pageNumber={number}&pageSize={number}': Retrieves a list of all national parks for the specified page number and page size.

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

* _V1 and V2 works, V3 just does ***not*** work with authentication yet_

## License


_Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:_

_The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software._

_THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE._

_Copyright (c) _2023_ _Joseph Wilfong_