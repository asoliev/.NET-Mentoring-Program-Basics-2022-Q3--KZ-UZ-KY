# Logging
 https://learn.epam.com/myLearning/program?groupGuid=b4184d1c-6350-42d6-bacc-43814944979a

### The module consists of the following topics:
- Logging
- Performance counters
- Classical (unstructured) logging systems: TraceSource, Nlog, log4net
- Capture and analyse logs

### Questions for the self-check:
1.	What is logging? 
2.	What information needs to be logged?
3.	What log levels do you know and how do they differ from each other?
4.	What is ILogger in .NET Core?
5.	Is it possible to stop logging with Serilog? If "yes", how can you do it?
6.	What information is good to include in a log message?
7.	How can Exceptions be logged?
8.	What is the default log level?
9.	Where can custom logging provider and corresponding logger be registered?

### Task 1:
Add logging to file for the BrainstormSessions project (attached) using Serilog. Several log levels must be present (at least, Error, Info and Debug).

### Task 2:
Using Serilog add an ability to email logs using SMTP (SmtpPickupDirAppender) for the BrainstormSessions project (attached).

### NB! Scoreboard:
- 1-3 stars – Only one task is completed. Or both tasks have major issues. Tasks 1 or Task 2 is completed according to the requirements with minor errors. 
- 4 stars – Both tasks are completed with minor issues.
- 5 stars – Both tasks are completed and meet the requirements.