# Getting started with Wizemen.NET

## Installing Library

To be able to use the library and it's features, you must include this in your project.

Install with Install-Package (Visual Studio): `Install-Package Wizemen.NET`  
or      
Install with dotnet CLI: `dotnet add package Wizemen.NET`

## Creating Client

You can create a Client by calling the `NewClientAsync` method.

```csharp  
// Replace with your credentials
Credentials credentials = new Credentials("wizemen@example.com", "pa$$w0rd", SchoolCode.Psg);  
WizemenClient client = await WizemenClient.NewClientAsync(credentials);
```

---  
If an invalid *format* is put for the email, a  `ArgumentException` is thrown.  
If the credentials provided were incorrect, a `InvalidCredentialException` is thrown.

## Using the Client

Once the client is successfuly created, you can access it's methods that return deserialized data.  
For example, you can fetch all your meetings by calling the `GetMeetingsAsync` method. Note that this takes
a `MeetingType` as it's parameter.

```csharp
// Get all scheduled zoom meetings
List<Meeting> zoomMeetings = await client.GetMeetingsAsync(MeetingType.Zoom);

// Get all scheduled team meetings
List<Meeting> teamMeetings = await client.GetMeetingsAsync(MeetingType.Teams);
```

## How can I go through all the features?

You can refer to the [documentation](/api) to find all methods.

## End note

Thanks a lot for spending your time reading this! If you have any suggestion, feature request, or encounter any issue,
please [create an issue](https://github.com/DhrumanGupta/Wizemen.NET/issues/new/choose) and let me know.