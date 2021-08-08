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
- [ClassAttendance](#T-Wizemen-NET-Models-ClassAttendance 'Wizemen.NET.Models.ClassAttendance')
  - [AbsentExcused](#P-Wizemen-NET-Models-ClassAttendance-AbsentExcused 'Wizemen.NET.Models.ClassAttendance.AbsentExcused')
  - [AbsentUnexcused](#P-Wizemen-NET-Models-ClassAttendance-AbsentUnexcused 'Wizemen.NET.Models.ClassAttendance.AbsentUnexcused')
  - [Als](#P-Wizemen-NET-Models-ClassAttendance-Als 'Wizemen.NET.Models.ClassAttendance.Als')
  - [EarlyDismissal](#P-Wizemen-NET-Models-ClassAttendance-EarlyDismissal 'Wizemen.NET.Models.ClassAttendance.EarlyDismissal')
  - [ExamLeave](#P-Wizemen-NET-Models-ClassAttendance-ExamLeave 'Wizemen.NET.Models.ClassAttendance.ExamLeave')
  - [Exeat](#P-Wizemen-NET-Models-ClassAttendance-Exeat 'Wizemen.NET.Models.ClassAttendance.Exeat')
  - [LateExcused](#P-Wizemen-NET-Models-ClassAttendance-LateExcused 'Wizemen.NET.Models.ClassAttendance.LateExcused')
  - [LateUnexcused](#P-Wizemen-NET-Models-ClassAttendance-LateUnexcused 'Wizemen.NET.Models.ClassAttendance.LateUnexcused')
  - [NotExpected](#P-Wizemen-NET-Models-ClassAttendance-NotExpected 'Wizemen.NET.Models.ClassAttendance.NotExpected')
  - [Present](#P-Wizemen-NET-Models-ClassAttendance-Present 'Wizemen.NET.Models.ClassAttendance.Present')
  - [PresentInClass](#P-Wizemen-NET-Models-ClassAttendance-PresentInClass 'Wizemen.NET.Models.ClassAttendance.PresentInClass')
  - [PresentOnline](#P-Wizemen-NET-Models-ClassAttendance-PresentOnline 'Wizemen.NET.Models.ClassAttendance.PresentOnline')
  - [RepresentingSchool](#P-Wizemen-NET-Models-ClassAttendance-RepresentingSchool 'Wizemen.NET.Models.ClassAttendance.RepresentingSchool')
  - [SchoolTrip](#P-Wizemen-NET-Models-ClassAttendance-SchoolTrip 'Wizemen.NET.Models.ClassAttendance.SchoolTrip')
  - [SentHome](#P-Wizemen-NET-Models-ClassAttendance-SentHome 'Wizemen.NET.Models.ClassAttendance.SentHome')
  - [StudentIllness](#P-Wizemen-NET-Models-ClassAttendance-StudentIllness 'Wizemen.NET.Models.ClassAttendance.StudentIllness')
  - [Subject](#P-Wizemen-NET-Models-ClassAttendance-Subject 'Wizemen.NET.Models.ClassAttendance.Subject')
  - [Suspended](#P-Wizemen-NET-Models-ClassAttendance-Suspended 'Wizemen.NET.Models.ClassAttendance.Suspended')
  - [TeacherFullName](#P-Wizemen-NET-Models-ClassAttendance-TeacherFullName 'Wizemen.NET.Models.ClassAttendance.TeacherFullName')
  - [TotalClasses](#P-Wizemen-NET-Models-ClassAttendance-TotalClasses 'Wizemen.NET.Models.ClassAttendance.TotalClasses')
- [Credentials](#T-Wizemen-NET-Models-Credentials 'Wizemen.NET.Models.Credentials')
  - [#ctor(email,password,schoolCode)](#M-Wizemen-NET-Models-Credentials-#ctor-System-String,System-String,Wizemen-NET-Models-SchoolCode- 'Wizemen.NET.Models.Credentials.#ctor(System.String,System.String,Wizemen.NET.Models.SchoolCode)')
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
- [MasterAttendance](#T-Wizemen-NET-Models-MasterAttendance 'Wizemen.NET.Models.MasterAttendance')
  - [Absent](#P-Wizemen-NET-Models-MasterAttendance-Absent 'Wizemen.NET.Models.MasterAttendance.Absent')
  - [Imperfect](#P-Wizemen-NET-Models-MasterAttendance-Imperfect 'Wizemen.NET.Models.MasterAttendance.Imperfect')
  - [Present](#P-Wizemen-NET-Models-MasterAttendance-Present 'Wizemen.NET.Models.MasterAttendance.Present')
  - [TotalDays](#P-Wizemen-NET-Models-MasterAttendance-TotalDays 'Wizemen.NET.Models.MasterAttendance.TotalDays')
- [Meeting](#T-Wizemen-NET-Models-Meeting 'Wizemen.NET.Models.Meeting')
  - [Agenda](#P-Wizemen-NET-Models-Meeting-Agenda 'Wizemen.NET.Models.Meeting.Agenda')
  - [Duration](#P-Wizemen-NET-Models-Meeting-Duration 'Wizemen.NET.Models.Meeting.Duration')
  - [Host](#P-Wizemen-NET-Models-Meeting-Host 'Wizemen.NET.Models.Meeting.Host')
  - [Id](#P-Wizemen-NET-Models-Meeting-Id 'Wizemen.NET.Models.Meeting.Id')
  - [JoinUrl](#P-Wizemen-NET-Models-Meeting-JoinUrl 'Wizemen.NET.Models.Meeting.JoinUrl')
  - [Password](#P-Wizemen-NET-Models-Meeting-Password 'Wizemen.NET.Models.Meeting.Password')
  - [StartTime](#P-Wizemen-NET-Models-Meeting-StartTime 'Wizemen.NET.Models.Meeting.StartTime')
  - [Topic](#P-Wizemen-NET-Models-Meeting-Topic 'Wizemen.NET.Models.Meeting.Topic')
- [MeetingType](#T-Wizemen-NET-Models-MeetingType 'Wizemen.NET.Models.MeetingType')
  - [Teams](#F-Wizemen-NET-Models-MeetingType-Teams 'Wizemen.NET.Models.MeetingType.Teams')
  - [Zoom](#F-Wizemen-NET-Models-MeetingType-Zoom 'Wizemen.NET.Models.MeetingType.Zoom')
- [SchoolCode](#T-Wizemen-NET-Models-SchoolCode 'Wizemen.NET.Models.SchoolCode')
  - [Psg](#F-Wizemen-NET-Models-SchoolCode-Psg 'Wizemen.NET.Models.SchoolCode.Psg')
  - [Psn](#F-Wizemen-NET-Models-SchoolCode-Psn 'Wizemen.NET.Models.SchoolCode.Psn')
  - [Pws](#F-Wizemen-NET-Models-SchoolCode-Pws 'Wizemen.NET.Models.SchoolCode.Pws')
- [Student](#T-Wizemen-NET-Models-Student 'Wizemen.NET.Models.Student')
  - [Birthday](#P-Wizemen-NET-Models-Student-Birthday 'Wizemen.NET.Models.Student.Birthday')
  - [FirstName](#P-Wizemen-NET-Models-Student-FirstName 'Wizemen.NET.Models.Student.FirstName')
  - [HomeroomTeacherName](#P-Wizemen-NET-Models-Student-HomeroomTeacherName 'Wizemen.NET.Models.Student.HomeroomTeacherName')
  - [ImageUrl](#P-Wizemen-NET-Models-Student-ImageUrl 'Wizemen.NET.Models.Student.ImageUrl')
  - [LastName](#P-Wizemen-NET-Models-Student-LastName 'Wizemen.NET.Models.Student.LastName')
  - [MiddleName](#P-Wizemen-NET-Models-Student-MiddleName 'Wizemen.NET.Models.Student.MiddleName')
  - [Parent1Email](#P-Wizemen-NET-Models-Student-Parent1Email 'Wizemen.NET.Models.Student.Parent1Email')
  - [Parent1FirstName](#P-Wizemen-NET-Models-Student-Parent1FirstName 'Wizemen.NET.Models.Student.Parent1FirstName')
  - [Parent1LastName](#P-Wizemen-NET-Models-Student-Parent1LastName 'Wizemen.NET.Models.Student.Parent1LastName')
  - [Parent1Mobile](#P-Wizemen-NET-Models-Student-Parent1Mobile 'Wizemen.NET.Models.Student.Parent1Mobile')
  - [Parent2Email](#P-Wizemen-NET-Models-Student-Parent2Email 'Wizemen.NET.Models.Student.Parent2Email')
  - [Parent2FirstName](#P-Wizemen-NET-Models-Student-Parent2FirstName 'Wizemen.NET.Models.Student.Parent2FirstName')
  - [Parent2LastName](#P-Wizemen-NET-Models-Student-Parent2LastName 'Wizemen.NET.Models.Student.Parent2LastName')
  - [Parent2Mobile](#P-Wizemen-NET-Models-Student-Parent2Mobile 'Wizemen.NET.Models.Student.Parent2Mobile')
  - [ResidentStatus](#P-Wizemen-NET-Models-Student-ResidentStatus 'Wizemen.NET.Models.Student.ResidentStatus')
  - [SchoolLevel](#P-Wizemen-NET-Models-Student-SchoolLevel 'Wizemen.NET.Models.Student.SchoolLevel')
  - [StudentEmail](#P-Wizemen-NET-Models-Student-StudentEmail 'Wizemen.NET.Models.Student.StudentEmail')
  - [UserId](#P-Wizemen-NET-Models-Student-UserId 'Wizemen.NET.Models.Student.UserId')
- [WizemenClient](#T-Wizemen-NET-Clients-WizemenClient 'Wizemen.NET.Clients.WizemenClient')
  - [GetAttendanceStatusAsync()](#M-Wizemen-NET-Clients-WizemenClient-GetAttendanceStatusAsync 'Wizemen.NET.Clients.WizemenClient.GetAttendanceStatusAsync')
  - [GetClassListAsync(classId)](#M-Wizemen-NET-Clients-WizemenClient-GetClassListAsync-System-Int32- 'Wizemen.NET.Clients.WizemenClient.GetClassListAsync(System.Int32)')
  - [GetClassesAsync()](#M-Wizemen-NET-Clients-WizemenClient-GetClassesAsync 'Wizemen.NET.Clients.WizemenClient.GetClassesAsync')
  - [GetEventsAsync()](#M-Wizemen-NET-Clients-WizemenClient-GetEventsAsync 'Wizemen.NET.Clients.WizemenClient.GetEventsAsync')
  - [GetMasterAttendanceAsync()](#M-Wizemen-NET-Clients-WizemenClient-GetMasterAttendanceAsync 'Wizemen.NET.Clients.WizemenClient.GetMasterAttendanceAsync')
  - [GetMeetingsAsync(meetingType)](#M-Wizemen-NET-Clients-WizemenClient-GetMeetingsAsync-Wizemen-NET-Models-MeetingType- 'Wizemen.NET.Clients.WizemenClient.GetMeetingsAsync(Wizemen.NET.Models.MeetingType)')
  - [NewClientAsync(credentials)](#M-Wizemen-NET-Clients-WizemenClient-NewClientAsync-Wizemen-NET-Models-Credentials- 'Wizemen.NET.Clients.WizemenClient.NewClientAsync(Wizemen.NET.Models.Credentials)')

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

<a name='T-Wizemen-NET-Models-ClassAttendance'></a>
## ClassAttendance `type`

##### Namespace

Wizemen.NET.Models

##### Summary

Attendance data for a class

<a name='P-Wizemen-NET-Models-ClassAttendance-AbsentExcused'></a>
### AbsentExcused `property`

##### Summary

No. of classes the student was marked as Absent Excused

<a name='P-Wizemen-NET-Models-ClassAttendance-AbsentUnexcused'></a>
### AbsentUnexcused `property`

##### Summary

No. of classes the student was marked as Absent Unexcused

<a name='P-Wizemen-NET-Models-ClassAttendance-Als'></a>
### Als `property`

##### Summary

No. of classes the student was marked for ALS

<a name='P-Wizemen-NET-Models-ClassAttendance-EarlyDismissal'></a>
### EarlyDismissal `property`

##### Summary

No. of classes the student was marked for Early Dismissal

<a name='P-Wizemen-NET-Models-ClassAttendance-ExamLeave'></a>
### ExamLeave `property`

##### Summary

No. of classes the student was marked for Exam Leave

<a name='P-Wizemen-NET-Models-ClassAttendance-Exeat'></a>
### Exeat `property`

##### Summary

No. of classes the student was marked Exeat

<a name='P-Wizemen-NET-Models-ClassAttendance-LateExcused'></a>
### LateExcused `property`

##### Summary

No. of classes the student was marked Late Excused

<a name='P-Wizemen-NET-Models-ClassAttendance-LateUnexcused'></a>
### LateUnexcused `property`

##### Summary

No. of classes the student was marked Late Unexcused

<a name='P-Wizemen-NET-Models-ClassAttendance-NotExpected'></a>
### NotExpected `property`

##### Summary

No. of classes the student was marked Not Expected

<a name='P-Wizemen-NET-Models-ClassAttendance-Present'></a>
### Present `property`

##### Summary

No. of classes the student was marked present for.

<a name='P-Wizemen-NET-Models-ClassAttendance-PresentInClass'></a>
### PresentInClass `property`

##### Summary

No. of classes the student was marked as Present In Class

<a name='P-Wizemen-NET-Models-ClassAttendance-PresentOnline'></a>
### PresentOnline `property`

##### Summary

No. of classes the student was marked as Present Online

<a name='P-Wizemen-NET-Models-ClassAttendance-RepresentingSchool'></a>
### RepresentingSchool `property`

##### Summary

No. of classes the student was marked for Representing School

<a name='P-Wizemen-NET-Models-ClassAttendance-SchoolTrip'></a>
### SchoolTrip `property`

##### Summary

No. of classes the student was marked for School Tri[

<a name='P-Wizemen-NET-Models-ClassAttendance-SentHome'></a>
### SentHome `property`

##### Summary

No. of classes the student was marked absent for being Sent Home

<a name='P-Wizemen-NET-Models-ClassAttendance-StudentIllness'></a>
### StudentIllness `property`

##### Summary

No. of classes the student was marked absent for Illness

<a name='P-Wizemen-NET-Models-ClassAttendance-Subject'></a>
### Subject `property`

##### Summary

The subject the attendance is regarding

<a name='P-Wizemen-NET-Models-ClassAttendance-Suspended'></a>
### Suspended `property`

##### Summary

No. of classes the student was marked Suspended

<a name='P-Wizemen-NET-Models-ClassAttendance-TeacherFullName'></a>
### TeacherFullName `property`

##### Summary

The subject's teacher's full name

<a name='P-Wizemen-NET-Models-ClassAttendance-TotalClasses'></a>
### TotalClasses `property`

##### Summary

Total No. of classes conducted for the subject

<a name='T-Wizemen-NET-Models-Credentials'></a>
## Credentials `type`

##### Namespace

Wizemen.NET.Models

##### Summary

Credentials object used to authenticate user

<a name='M-Wizemen-NET-Models-Credentials-#ctor-System-String,System-String,Wizemen-NET-Models-SchoolCode-'></a>
### #ctor(email,password,schoolCode) `constructor`

##### Summary

Creates the credentials object

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| email | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user's Wizemen Email Address |
| password | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The user's Wizemen Password |
| schoolCode | [Wizemen.NET.Models.SchoolCode](#T-Wizemen-NET-Models-SchoolCode 'Wizemen.NET.Models.SchoolCode') | The user's SchoolCode |

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

The school's Name (Auto generated depending on the [SchoolCode](#P-Wizemen-NET-Models-Credentials-SchoolCode 'Wizemen.NET.Models.Credentials.SchoolCode'))

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

<a name='T-Wizemen-NET-Models-MasterAttendance'></a>
## MasterAttendance `type`

##### Namespace

Wizemen.NET.Models

##### Summary

Master attendance for a user

<a name='P-Wizemen-NET-Models-MasterAttendance-Absent'></a>
### Absent `property`

##### Summary

Days the user had an Absent attendance

<a name='P-Wizemen-NET-Models-MasterAttendance-Imperfect'></a>
### Imperfect `property`

##### Summary

Days the user had an Imperfect attendance

<a name='P-Wizemen-NET-Models-MasterAttendance-Present'></a>
### Present `property`

##### Summary

Days the user had a Present attendance

<a name='P-Wizemen-NET-Models-MasterAttendance-TotalDays'></a>
### TotalDays `property`

##### Summary

Total days of the attendance

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

<a name='T-Wizemen-NET-Models-MeetingType'></a>
## MeetingType `type`

##### Namespace

Wizemen.NET.Models

##### Summary

Defines the possible meeting types. Used when getting a meeting

<a name='F-Wizemen-NET-Models-MeetingType-Teams'></a>
### Teams `constants`

##### Summary

Teams meetings

<a name='F-Wizemen-NET-Models-MeetingType-Zoom'></a>
### Zoom `constants`

##### Summary

Zoom meetings

<a name='T-Wizemen-NET-Models-SchoolCode'></a>
## SchoolCode `type`

##### Namespace

Wizemen.NET.Models

##### Summary

The school code of the user's school

<a name='F-Wizemen-NET-Models-SchoolCode-Psg'></a>
### Psg `constants`

##### Summary

Pathways School Gurgaon

<a name='F-Wizemen-NET-Models-SchoolCode-Psn'></a>
### Psn `constants`

##### Summary

Pathways School Noida

<a name='F-Wizemen-NET-Models-SchoolCode-Pws'></a>
### Pws `constants`

##### Summary

Pathways World School, Aravali

<a name='T-Wizemen-NET-Models-Student'></a>
## Student `type`

##### Namespace

Wizemen.NET.Models

##### Summary

The student object containing all public details of a student

<a name='P-Wizemen-NET-Models-Student-Birthday'></a>
### Birthday `property`

##### Summary

The student's birthday

<a name='P-Wizemen-NET-Models-Student-FirstName'></a>
### FirstName `property`

##### Summary

The student's first name

<a name='P-Wizemen-NET-Models-Student-HomeroomTeacherName'></a>
### HomeroomTeacherName `property`

##### Summary

The name of the student's Homeroom Teacher

<a name='P-Wizemen-NET-Models-Student-ImageUrl'></a>
### ImageUrl `property`

##### Summary

The image URL for the student's Wizemen image

<a name='P-Wizemen-NET-Models-Student-LastName'></a>
### LastName `property`

##### Summary

The student's last name (null if not found)

<a name='P-Wizemen-NET-Models-Student-MiddleName'></a>
### MiddleName `property`

##### Summary

The student's middle name (null if not found)

<a name='P-Wizemen-NET-Models-Student-Parent1Email'></a>
### Parent1Email `property`

##### Summary

The student's first parent's email

<a name='P-Wizemen-NET-Models-Student-Parent1FirstName'></a>
### Parent1FirstName `property`

##### Summary

The student's first parent's first name

<a name='P-Wizemen-NET-Models-Student-Parent1LastName'></a>
### Parent1LastName `property`

##### Summary

The student's first parent's last name

<a name='P-Wizemen-NET-Models-Student-Parent1Mobile'></a>
### Parent1Mobile `property`

##### Summary

The student's first parent's mobile no.

<a name='P-Wizemen-NET-Models-Student-Parent2Email'></a>
### Parent2Email `property`

##### Summary

The student's second parent's email

<a name='P-Wizemen-NET-Models-Student-Parent2FirstName'></a>
### Parent2FirstName `property`

##### Summary

The student's second parent's first name

<a name='P-Wizemen-NET-Models-Student-Parent2LastName'></a>
### Parent2LastName `property`

##### Summary

The student's second parent's second name

<a name='P-Wizemen-NET-Models-Student-Parent2Mobile'></a>
### Parent2Mobile `property`

##### Summary

The student's second parent's mobile no.

<a name='P-Wizemen-NET-Models-Student-ResidentStatus'></a>
### ResidentStatus `property`

##### Summary

The residency status of the student ("Day Student", etc) (Not an enum since other status are not tested)

<a name='P-Wizemen-NET-Models-Student-SchoolLevel'></a>
### SchoolLevel `property`

##### Summary

The student's school level ("Senior School", etc) (Not an enum since middle school is not tested)

<a name='P-Wizemen-NET-Models-Student-StudentEmail'></a>
### StudentEmail `property`

##### Summary

The student's school email

<a name='P-Wizemen-NET-Models-Student-UserId'></a>
### UserId `property`

##### Summary

The user Id of the student

<a name='T-Wizemen-NET-Clients-WizemenClient'></a>
## WizemenClient `type`

##### Namespace

Wizemen.NET.Clients

##### Summary

Client class used to interact with the API.

<a name='M-Wizemen-NET-Clients-WizemenClient-GetAttendanceStatusAsync'></a>
### GetAttendanceStatusAsync() `method`

##### Summary

Returns the attendance status for all classes of an authenticated user

##### Returns

The attendance list found. Returns null if not found (unauthorized or server error)

##### Parameters

This method has no parameters.

<a name='M-Wizemen-NET-Clients-WizemenClient-GetClassListAsync-System-Int32-'></a>
### GetClassListAsync(classId) `method`

##### Summary

Returns a list of all the students in a class

##### Returns

A list of the students found. Returns an empty list if none were found (invalid classId)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| classId | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The classId to get the students in |

<a name='M-Wizemen-NET-Clients-WizemenClient-GetClassesAsync'></a>
### GetClassesAsync() `method`

##### Summary

Gets the classes of the authenticated user

##### Returns

The classes found. Returns an empty list if none were found

##### Parameters

This method has no parameters.

<a name='M-Wizemen-NET-Clients-WizemenClient-GetEventsAsync'></a>
### GetEventsAsync() `method`

##### Summary

Gets the events of the authenticated user

##### Returns

The events found. Returns an empty list if none were found

##### Parameters

This method has no parameters.

<a name='M-Wizemen-NET-Clients-WizemenClient-GetMasterAttendanceAsync'></a>
### GetMasterAttendanceAsync() `method`

##### Summary

Gets the master attendance (not specific to any subject) for the authenticated user

##### Returns

The master attendance object found. Returns null if data was not found

##### Parameters

This method has no parameters.

<a name='M-Wizemen-NET-Clients-WizemenClient-GetMeetingsAsync-Wizemen-NET-Models-MeetingType-'></a>
### GetMeetingsAsync(meetingType) `method`

##### Summary

Gets the meetings for the authenticated user

##### Returns

The meetings found. Returns an empty list if none were found

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| meetingType | [Wizemen.NET.Models.MeetingType](#T-Wizemen-NET-Models-MeetingType 'Wizemen.NET.Models.MeetingType') | The type of meeting to get |

<a name='M-Wizemen-NET-Clients-WizemenClient-NewClientAsync-Wizemen-NET-Models-Credentials-'></a>
### NewClientAsync(credentials) `method`

##### Summary

Creates a client used to interact with the API asynchronously

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| credentials | [Wizemen.NET.Models.Credentials](#T-Wizemen-NET-Models-Credentials 'Wizemen.NET.Models.Credentials') | The credentials object with the user's credentials |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Security.Authentication.InvalidCredentialException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.Authentication.InvalidCredentialException 'System.Security.Authentication.InvalidCredentialException') | Thrown if the credentials provided were invalid |
