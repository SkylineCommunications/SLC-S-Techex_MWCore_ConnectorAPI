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
Here's a quick guide to help you get started with the ConnectorAPI Techex MWCore NuGet package:


Create an MWCoreInterAppCalls object to get started.
```csharp
// For Automation Scripts
var exampleElement = new MWCoreInterAppCalls(engine.GetUserConnection(), agentId, elementId);

// For Connectors
var exampleElement = new MWCoreInterAppCalls(protocol.SLNet.RawConnection, agentId, elementId);
```


Create the message you need to send.
```csharp
var request = new MWCoreRequest
{
	Action = RequestAction.Create,
    Type = InterAppResourceType.Stream,
    EdgeName = "MWCoreEdge",
    Body = "Stream JSON configuration",
};
```

Send you message to the element.
```csharp
var response = exampleElement.SendSingleResponseMessage(request);
```

## Available Actions

Via the InterApp is possible to perform following actions on streams, sources and outputs:
- Create
- Delete
- Update

### Create Action

#### `Stream`

In order to create a stream via InterApp, the request message must contain these properties and values:

- ***Action:*** Create action value.
- ***Type:*** Stream type value.
- ***EdgeName:*** Edge name where the stream should be created.
- ***EdgeID:*** Edge ID where the stream should be created.
- ***Body:*** Stream configuration JSON. 

> **Note**
> Only one of the EdgeName or EdgeID properties is required to be filled in.
 
#### `Source`

In order to create an Source via InterApp, the request message must contain these properties and values:

- ***Action:*** Create action value.
- ***Type:*** Source type value.
- ***EdgeName:*** Edge name where the source should be created.
- ***EdgeID:*** Edge ID where the source should be created.
- ***Body:*** Source configuration JSON. 

> **Note**
> Only one of the EdgeName or EdgeID properties is required to be filled in.

#### `Output`

In order to create an output via InterApp, the request message must contain these properties and values:

- ***Action:*** Create action value.
- ***Type:*** Output type value.
- ***EdgeName:*** Edge name where the output should be created.
- ***EdgeID:*** Edge ID where the output should be created.
- ***Body:*** Output configuration JSON. 

> **Note**
> Only one of the EdgeName or EdgeID properties is required to be filled in.

### Delete Action

#### `Stream`

In order to delete a stream via InterApp, the request message must contain these properties and values:

- ***Action:*** Delete action value.
- ***Type:*** Stream type value.
- ***Body:*** DataMiner stream display key (Can be found in the Streams table).

#### `Source`

In order to delete an Source via InterApp, the request message must contain these properties and values:

- ***Action:*** Delete action value.
- ***Type:*** Source type value.
- ***Body:*** DataMiner Source display key (Can be found in the Sources table).

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
- ***Body:*** Stream configuration JSON. 

#### `Source`

In order to update an Source via InterApp, the request message must contain these properties and values:

- ***Action:*** Update action value.
- ***Type:*** Source type value.
- ***ResourceToUpdate:*** DataMiner source primary key (Can be found in the Sources table).
- ***Body:*** Source configuration JSON. 

#### `Output`

In order to update an output via InterApp, the request message must contain these properties and values:

- ***Action:*** Update action value.
- ***Type:*** Output type value.
- ***ResourceToUpdate:*** DataMiner output primary key (Can be found in the Outputs table).
- ***Body:***  Output configuration JSON.

### Response

For every request send the MWCore element sends a response back containing these properties and values:

- ***Successful:*** True if the request was successful or False otherwise.
- ***Type:*** Requested resource type value (Stream, Source, Output).
- ***Resource:*** Requested resource DataMiner display key.
- ***Error:*** Shows the error message for the unsuccessful request.