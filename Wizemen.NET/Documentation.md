<?xml version="1.0"?>
<doc>
    <assembly>
        <name>Wizemen.NET</name>
    </assembly>
    <members>
        <member name="T:Wizemen.NET.Models.Class">
            <summary>
            A wizemen class a user is enrolled in
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Class.ProgramName">
            <summary>
            Name of the program the user is in (PYP, MYP, DP)
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Class.Grade">
            <summary>
            The user's current grade
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Class.ClassId">
            <summary>
            The id of the class
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Class.TeacherId">
            <summary>
            The id of the class's teacher
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Class.TeacherName">
            <summary>
            The Name of the class's teacher
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Class.ClassCode">
            <summary>
            The class's code
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Class.Subject">
            <summary>
            The subject of the class
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Class.Course">
            <summary>
            The course of the class
            </summary>
        </member>
        <member name="M:Wizemen.NET.Models.Credentials.#ctor(System.String,System.String,Wizemen.NET.SchoolCode)">
            <summary>
            Creates the credentials object
            </summary>
            <param name="email">The user's Wizemen Email Address</param>
            <param name="password">The user's Wizemen Password</param>
            <param name="schoolCode">The user's SchoolCode</param>
            <exception cref="T:System.ArgumentException">Thrown if email provided was not in a correct format</exception>
        </member>
        <member name="P:Wizemen.NET.Models.Credentials.Email">
            <summary>
            The user's Wizemen Email
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Credentials.Password">
            <summary>
            The user's Wizemen Password
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Credentials.SchoolCode">
            <summary>
            The user's Wizemen School Code
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Credentials.SchoolName">
            <summary>
            The school's Name (Auto generated depending on <see cref="P:Wizemen.NET.Models.Credentials.SchoolCode"/>)
            </summary>
        </member>
        <member name="T:Wizemen.NET.Models.Event">
            <summary>
            An event for a user
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Event.Type">
            <summary>
            The type of event
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Event.Id">
            <summary>
            The id of the event
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Event.Title">
            <summary>
            The event's Title
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Event.Data">
            <summary>
            Additional data (eg: description) for the event
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Event.StartDate">
            <summary>
            The start date for the event
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Event.EndDate">
            <summary>
            The end date for the event
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Event.ColorCode">
            <summary>
            The color code the event is displayed in
            </summary>
        </member>
        <member name="T:Wizemen.NET.Models.Meeting">
            <summary>
            A meeting a user can join
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Meeting.Topic">
            <summary>
            The topic of the meeting
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Meeting.StartTime">
            <summary>
            The time the meeting starts
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Meeting.Duration">
            <summary>
            The duration of the meeting
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Meeting.Agenda">
            <summary>
            The agenda set by the teacher for the meeting
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Meeting.JoinUrl">
            <summary>
            The URL to join the meeting with (contains id and pwd for zoom)
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Meeting.Id">
            <summary>
            The zoom meeting id
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Meeting.Password">
            <summary>
            The zoom meeting password
            </summary>
        </member>
        <member name="P:Wizemen.NET.Models.Meeting.Host">
            <summary>
            The name of the user who is hosting the meeting
            </summary>
        </member>
        <member name="T:Wizemen.NET.SchoolCode">
            <summary>
            The school code of the user's school
            </summary>
        </member>
        <member name="T:Wizemen.NET.WizemenClient">
            <summary>
            Client class used to interact with the API.
            </summary>
        </member>
        <member name="M:Wizemen.NET.WizemenClient.#ctor(Wizemen.NET.Models.Credentials)">
            <summary>
            Creates a client used to interact with the API
            </summary>
            <param name="credentials">The credentials object with the user's credentials</param>
        </member>
        <member name="M:Wizemen.NET.WizemenClient.StartAsync">
            <summary>
            Login, generate a cookie, and verify the cookie to enable access to the API.
            </summary>
        </member>
        <member name="M:Wizemen.NET.WizemenClient.GetMeetingsAsync">
            <summary>
            Gets the meetings for the authenticated user
            </summary>
            <returns>The meetings found. Returns an empty list if none were found</returns>
        </member>
        <member name="M:Wizemen.NET.WizemenClient.GetClassesAsync">
            <summary>
            Gets the classes of the authenticated user
            </summary>
            <returns>The classes found. Returns an empty list if none were found</returns>
        </member>
        <member name="M:Wizemen.NET.WizemenClient.GetEventsAsync">
            <summary>
            Gets the events of the authenticated user
            </summary>
            <returns>The events found. Returns an empty list if none were found</returns>
        </member>
    </members>
</doc>
