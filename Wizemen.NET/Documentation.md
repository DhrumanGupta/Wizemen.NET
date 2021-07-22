<a name='assembly'></a>
# Wizemen.NET

## Contents

- [Class](#T-Wizemen-NET-Models-Class 'Wizemen.NET.Models.Class')
  - [ClassCode](#P-Wizemen-NET-Models-Class-ClassCode 'Wizemen.NET.Models.Class.ClassCode')
  - [ClassId](#P-Wizemen-NET-Models-Class-ClassId 'Wizemen.NET.Models.Class.ClassId')
  - [Course](#P-Wizemen-NET-Models-Class-Course 'Wizemen.NET.Models.Class.Course')
  - [Grade](#P-Wizemen-NET-Models-Class-Grade 'Wizemen.NET.Models.Class.Grade')
  - [ProgramName](#P-Wizemen-NET-Models-Class-ProgramName 'Wizemen.NET.Models.Class.ProgramName')
  - [Subject](#P-Wizemen-NET-Models-Class-Subject 'Wizemen.NET.Models.Class.Subject')
  - [TeacherId](#P-Wizemen-NET-Models-Class-TeacherId 'Wizemen.NET.Models.Class.TeacherId')
  - [TeacherName](#P-Wizemen-NET-Models-Class-TeacherName 'Wizemen.NET.Models.Class.TeacherName')
- [Credentials](#T-Wizemen-NET-Models-Credentials 'Wizemen.NET.Models.Credentials')
  - [#ctor(email,password,schoolCode)](#M-Wizemen-NET-Models-Credentials-#ctor-System-String,System-String,Wizemen-NET-SchoolCode- 'Wizemen.NET.Models.Credentials.#ctor(System.String,System.String,Wizemen.NET.SchoolCode)')
  - [Email](#P-Wizemen-NET-Models-Credentials-Email 'Wizemen.NET.Models.Credentials.Email')
  - [Password](#P-Wizemen-NET-Models-Credentials-Password 'Wizemen.NET.Models.Credentials.Password')
  - [SchoolCode](#P-Wizemen-NET-Models-Credentials-SchoolCode 'Wizemen.NET.Models.Credentials.SchoolCode')
  - [SchoolName](#P-Wizemen-NET-Models-Credentials-SchoolName 'Wizemen.NET.Models.Credentials.SchoolName')
- [Event](#T-Wizemen-NET-Models-Event 'Wizemen.NET.Models.Event')
  - [ColorCode](#P-Wizemen-NET-Models-Event-ColorCode 'Wizemen.NET.Models.Event.ColorCode')
  - [Data](#P-Wizemen-NET-Models-Event-Data 'Wizemen.NET.Models.Event.Data')
  - [EndDate](#P-Wizemen-NET-Models-Event-EndDate 'Wizemen.NET.Models.Event.EndDate')
  - [Id](#P-Wizemen-NET-Models-Event-Id 'Wizemen.NET.Models.Event.Id')
  - [StartDate](#P-Wizemen-NET-Models-Event-StartDate 'Wizemen.NET.Models.Event.StartDate')
  - [Title](#P-Wizemen-NET-Models-Event-Title 'Wizemen.NET.Models.Event.Title')
  - [Type](#P-Wizemen-NET-Models-Event-Type 'Wizemen.NET.Models.Event.Type')
- [Meeting](#T-Wizemen-NET-Models-Meeting 'Wizemen.NET.Models.Meeting')
  - [Agenda](#P-Wizemen-NET-Models-Meeting-Agenda 'Wizemen.NET.Models.Meeting.Agenda')
  - [Duration](#P-Wizemen-NET-Models-Meeting-Duration 'Wizemen.NET.Models.Meeting.Duration')
  - [Host](#P-Wizemen-NET-Models-Meeting-Host 'Wizemen.NET.Models.Meeting.Host')
  - [Id](#P-Wizemen-NET-Models-Meeting-Id 'Wizemen.NET.Models.Meeting.Id')
  - [JoinUrl](#P-Wizemen-NET-Models-Meeting-JoinUrl 'Wizemen.NET.Models.Meeting.JoinUrl')
  - [Password](#P-Wizemen-NET-Models-Meeting-Password 'Wizemen.NET.Models.Meeting.Password')
  - [StartTime](#P-Wizemen-NET-Models-Meeting-StartTime 'Wizemen.NET.Models.Meeting.StartTime')
  - [Topic](#P-Wizemen-NET-Models-Meeting-Topic 'Wizemen.NET.Models.Meeting.Topic')
- [SchoolCode](#T-Wizemen-NET-SchoolCode 'Wizemen.NET.SchoolCode')
- [WizemenClient](#T-Wizemen-NET-WizemenClient 'Wizemen.NET.WizemenClient')
  - [#ctor(credentials)](#M-Wizemen-NET-WizemenClient-#ctor-Wizemen-NET-Models-Credentials- 'Wizemen.NET.WizemenClient.#ctor(Wizemen.NET.Models.Credentials)')
  - [GetClassesAsync()](#M-Wizemen-NET-WizemenClient-GetClassesAsync 'Wizemen.NET.WizemenClient.GetClassesAsync')
  - [GetEventsAsync()](#M-Wizemen-NET-WizemenClient-GetEventsAsync 'Wizemen.NET.WizemenClient.GetEventsAsync')
  - [GetMeetingsAsync()](#M-Wizemen-NET-WizemenClient-GetMeetingsAsync 'Wizemen.NET.WizemenClient.GetMeetingsAsync')
  - [StartAsync()](#M-Wizemen-NET-WizemenClient-StartAsync 'Wizemen.NET.WizemenClient.StartAsync')

<a name='T-Wizemen-NET-Models-Class'></a>
## Class `type`

##### Namespace

Wizemen.NET.Models

##### Summary

A wizemen class a user is enrolled in

<a name='P-Wizemen-NET-Models-Class-ClassCode'></a>
### ClassCode `property`

##### Summary

The class's code

<a name='P-Wizemen-NET-Models-Class-ClassId'></a>
### ClassId `property`

##### Summary

The id of the class

<a name='P-Wizemen-NET-Models-Class-Course'></a>
### Course `property`

##### Summary

The course of the class

<a name='P-Wizemen-NET-Models-Class-Grade'></a>
### Grade `property`

##### Summary

The user's current grade

<a name='P-Wizemen-NET-Models-Class-ProgramName'></a>
### ProgramName `property`

##### Summary

Name of the program the user is in (PYP, MYP, DP)

<a name='P-Wizemen-NET-Models-Class-Subject'></a>
### Subject `property`

##### Summary

The subject of the class

<a name='P-Wizemen-NET-Models-Class-TeacherId'></a>
### TeacherId `property`

##### Summary

The id of the class's teacher

<a name='P-Wizemen-NET-Models-Class-TeacherName'></a>
### TeacherName `property`

##### Summary

The Name of the class's teacher

<a name='T-Wizemen-NET-Models-Credentials'></a>
## Credentials `type`

##### Namespace

Wizemen.NET.Models

<a name='M-Wizemen-NET-Models-Credentials-#ctor-System-String,System-String,Wizemen-NET-SchoolCode-'></a>
### #ctor(email,password,schoolCode) `constructor`

##### Summary

Creates the credentials object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user's Wizemen Email Address |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user's Wizemen Password |
| schoolCode | [Wizemen.NET.SchoolCode](#T-Wizemen-NET-SchoolCode 'Wizemen.NET.SchoolCode') | The user's SchoolCode |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Thrown if email provided was not in a correct format |

<a name='P-Wizemen-NET-Models-Credentials-Email'></a>
### Email `property`

##### Summary

The user's Wizemen Email

<a name='P-Wizemen-NET-Models-Credentials-Password'></a>
### Password `property`

##### Summary

The user's Wizemen Password

<a name='P-Wizemen-NET-Models-Credentials-SchoolCode'></a>
### SchoolCode `property`

##### Summary

The user's Wizemen School Code

<a name='P-Wizemen-NET-Models-Credentials-SchoolName'></a>
### SchoolName `property`

##### Summary

The school's Name (Auto generated depending on [SchoolCode](#P-Wizemen-NET-Models-Credentials-SchoolCode 'Wizemen.NET.Models.Credentials.SchoolCode'))

<a name='T-Wizemen-NET-Models-Event'></a>
## Event `type`

##### Namespace

Wizemen.NET.Models

##### Summary

An event for a user

<a name='P-Wizemen-NET-Models-Event-ColorCode'></a>
### ColorCode `property`

##### Summary

The color code the event is displayed in

<a name='P-Wizemen-NET-Models-Event-Data'></a>
### Data `property`

##### Summary

Additional data (eg: description) for the event

<a name='P-Wizemen-NET-Models-Event-EndDate'></a>
### EndDate `property`

##### Summary

The end date for the event

<a name='P-Wizemen-NET-Models-Event-Id'></a>
### Id `property`

##### Summary

The id of the event

<a name='P-Wizemen-NET-Models-Event-StartDate'></a>
### StartDate `property`

##### Summary

The start date for the event

<a name='P-Wizemen-NET-Models-Event-Title'></a>
### Title `property`

##### Summary

The event's Title

<a name='P-Wizemen-NET-Models-Event-Type'></a>
### Type `property`

##### Summary

The type of event

<a name='T-Wizemen-NET-Models-Meeting'></a>
## Meeting `type`

##### Namespace

Wizemen.NET.Models

##### Summary

A meeting a user can join

<a name='P-Wizemen-NET-Models-Meeting-Agenda'></a>
### Agenda `property`

##### Summary

The agenda set by the teacher for the meeting

<a name='P-Wizemen-NET-Models-Meeting-Duration'></a>
### Duration `property`

##### Summary

The duration of the meeting

<a name='P-Wizemen-NET-Models-Meeting-Host'></a>
### Host `property`

##### Summary

The name of the user who is hosting the meeting

<a name='P-Wizemen-NET-Models-Meeting-Id'></a>
### Id `property`

##### Summary

The zoom meeting id

<a name='P-Wizemen-NET-Models-Meeting-JoinUrl'></a>
### JoinUrl `property`

##### Summary

The URL to join the meeting with (contains id and pwd for zoom)

<a name='P-Wizemen-NET-Models-Meeting-Password'></a>
### Password `property`

##### Summary

The zoom meeting password

<a name='P-Wizemen-NET-Models-Meeting-StartTime'></a>
### StartTime `property`

##### Summary

The time the meeting starts

<a name='P-Wizemen-NET-Models-Meeting-Topic'></a>
### Topic `property`

##### Summary

The topic of the meeting

<a name='T-Wizemen-NET-SchoolCode'></a>
## SchoolCode `type`

##### Namespace

Wizemen.NET

##### Summary

The school code of the user's school

<a name='T-Wizemen-NET-WizemenClient'></a>
## WizemenClient `type`

##### Namespace

Wizemen.NET

##### Summary

Client class used to interact with the API.

<a name='M-Wizemen-NET-WizemenClient-#ctor-Wizemen-NET-Models-Credentials-'></a>
### #ctor(credentials) `constructor`

##### Summary

Creates a client used to interact with the API

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| credentials | [Wizemen.NET.Models.Credentials](#T-Wizemen-NET-Models-Credentials 'Wizemen.NET.Models.Credentials') | The credentials object with the user's credentials |

<a name='M-Wizemen-NET-WizemenClient-GetClassesAsync'></a>
### GetClassesAsync() `method`

##### Summary

Gets the classes of the authenticated user

##### Returns

The classes found. Returns an empty list if none were found

##### Parameters

This method has no parameters.

<a name='M-Wizemen-NET-WizemenClient-GetEventsAsync'></a>
### GetEventsAsync() `method`

##### Summary

Gets the events of the authenticated user

##### Returns

The events found. Returns an empty list if none were found

##### Parameters

This method has no parameters.

<a name='M-Wizemen-NET-WizemenClient-GetMeetingsAsync'></a>
### GetMeetingsAsync() `method`

##### Summary

Gets the meetings for the authenticated user

##### Returns

The meetings found. Returns an empty list if none were found

##### Parameters

This method has no parameters.

<a name='M-Wizemen-NET-WizemenClient-StartAsync'></a>
### StartAsync() `method`

##### Summary

Login, generate a cookie, and verify the cookie to enable access to the API.

##### Parameters

This method has no parameters.
