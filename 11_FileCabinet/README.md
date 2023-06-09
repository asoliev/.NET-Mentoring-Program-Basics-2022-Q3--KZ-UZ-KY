# FileCabinet
 https://learn.epam.com/myLearning/program?groupGuid=d8951fce-b848-42aa-99c1-606b443aed19


Questions for the self-check:
1.	What are the four principles of object-oriented programming? Can you explain each in your own words?
2.	What is multiple inheritance? How are we able to achieve it in .NET?
3.	What do S.O.L.I.D. principles stand for? Can you decipher each letter?
4.	What other principles do you know, do they conflict or complement each other?



### Description
Given you are writing a file -cabinet software for a library. Currently the library works with the following document types: books, localized books, and patents and the following functionality is requested:

1. Ability to search for document cards by a document number.

2. The results should contain a list of card info which matches search requests.

3. The card info varies based on the document type.

4. Document cards are stored in the file system. Naming format is the following: type_#{number}.json

Document attributes by types:

- Patent (title, authors, date published, expiration date, unique id)

- Book (ISBN, title, authors, number of pages, publisher, date published)

- Localized book (ISBN, title, authors, number of pages, original publisher, country of localization, local publisher, date published)

### Task 1:
Create an application with the requested functionality (use the console app as UI for simplicity). Follow SOLID, DRY, KISS and YAGNI recommendations. Consider the ability to enhance the system in the following places:

1. Storage format could be changed to database/cloud storage in the future

2. New document types (like newspapers, magazines and so on)

3. There could be multiple UIs in the future (Desktop, Web, Mobile)

### Task 2:

Add support for a new type of document – magazine (title, publisher, release number, publish date). Include it in the search and output parts.

### Task 3:

Add ability to cache card info once read. This should decrease the load on the storage system. Cache time should be configurable based on the document type. Some document types could have no expiration date (live long cache) for cache, and some should not be cached at all.

### NB! Scoreboard:

5 stars:
All three tasks were completed. Implementation meets requirements and follows OOP principles and practices

4 stars:
Task1 and Task 2 were completed. Implementation meets requirements and follows OOP principles and practices.

1-3 stars:
Task1 was completed. Implementation meets requirements and follows OOP principles and practices.