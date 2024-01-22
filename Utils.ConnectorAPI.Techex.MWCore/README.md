# Skyline.DataMiner.Utils.ConnectorAPI.Techex.MWCore

## About

This nuget package contains classes for InterApp communication with the Techex MWCore protocol.

>**Note**
> Information about InterApp: [About InterApp](https://docs.dataminer.services/develop/devguide/ClassLibrary/ClassLibraryInterAppClasses.html?q=InterApp)

### About DataMiner

DataMiner is a transformational platform that provides vendor-independent control and monitoring of devices and services. Out of the box and by design, it addresses key challenges such as security, complexity, multi-cloud, and much more. It has a pronounced open architecture and powerful capabilities enabling users to evolve easily and continuously.

The foundation of DataMiner is its powerful and versatile data acquisition and control layer. With DataMiner, there are no restrictions to what data users can access. Data sources may reside on premises, in the cloud, or in a hybrid setup.

A unique catalog of 7000+ connectors already exist. In addition, you can leverage DataMiner Development Packages to build you own connectors (also known as "protocols" or "drivers").

> **Note**
> See also: [About DataMiner](https://aka.dataminer.services/about-dataminer).

### About Skyline Communications

At Skyline Communications, we deal in world-class solutions that are deployed by leading companies around the globe. Check out [our proven track record](https://aka.dataminer.services/about-skyline) and see how we make our customers' lives easier by empowering them to take their operations to the next level.

<!-- Uncomment below and add more info to provide more information about how to use this package. -->
## Getting Started

Via the InterApp is possible to performe following actions on streams, inputs and outputs:
- Create
- Delete
- Update

### Create Action

#### `Stream`

In order to create a stream via InterApp, the request message must contain these properties and values:

- ***Action:*** Create action value.
- ***Type:*** Stream type value.
- ***Edge:*** Edge name where the stream should be created.
- ***Body:*** Stream configuration json. 

#### `Input`

In order to create an input via InterApp, the request message must contain these properties and values:

- ***Action:*** Create action value.
- ***Type:*** Input type value.
- ***Edge:*** Edge ID where the input should be created.
- ***Body:*** Input configuration json. 

#### `Output`

In order to create an output via InterApp, the request message must contain these properties and values:

- ***Action:*** Create action value.
- ***Type:*** Output type value.
- ***Edge:*** Edge ID where the output should be created.
- ***Body:*** Ouput configuration json. 

### Delete Action

#### `Stream`

In order to delete a stream via InterApp, the request message must contain these properties and values:

- ***Action:*** Delete action value.
- ***Type:*** Stream type value.
- ***Body:*** DataMiner stream display key (Can be found in the Streams table).

#### `Input`

In order to delete an input via InterApp, the request message must contain these properties and values:

- ***Action:*** Delete action value.
- ***Type:*** Input type value.
- ***Body:*** DataMiner input display key (Can be found in the Input Sources table).

#### `Output`

In order to delete an output via InterApp, the request message must contain these properties and values:

- ***Action:*** Delete action value.
- ***Type:*** Output type value.
- ***Body:***  DataMiner output display key (Can be found in the Outputs table).

### Update Action

#### `Stream`

In order to update a stream via InterApp, the request message must contain these properties and values:

- ***Action:*** Update action value.
- ***Type:*** Stream type value.
- ***ResourceToUpdate:*** DataMiner stream primary key (Can be found in the Streams table).
- ***Body:*** Stream configuration json. 

#### `Input`

In order to update an input via InterApp, the request message must contain these properties and values:

- ***Action:*** Update action value.
- ***Type:*** Input type value.
- ***ResourceToUpdate:*** DataMiner input primary key (Can be found in the Input Sources table).
- ***Body:*** Input configuration json. 

#### `Output`

In order to update an output via InterApp, the request message must contain these properties and values:

- ***Action:*** Update action value.
- ***Type:*** Output type value.
- ***ResourceToUpdate:*** DataMiner output primary key (Can be found in the Outputs table).
- ***Body:***  Ouput configuration json.

### Response

For every request send the MWCore element sends a response back containing these properties and values:

- ***SuccessfulCreation:*** True if the request was successful or False otherwise.
- ***Type:*** Requested resource type value (Stream, Input, Output).
- ***Resource:*** Requested resource dataminer display key.
- ***Error:*** Shows the error message for the unsuccessful request.