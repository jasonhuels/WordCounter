# _WordCounter_

#### _A console application that counts the frequency of a word in a sentence , 4-October-2019_

#### By _**Jason Huels**_

## Description

_A console application that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. The program should ignore partial matches in words. Alternately, the user can choose to play a game in which the program will pick a random sentence from the text.txt file and a word from that sentence. The user will have 5 seconds to correctly identify the count of the word in that sentence._

## Specifications

| Completed | Behavior | Input | Output|
|:-|:------|:---------:|:------:|
- [X] | User enters word to match with no matches | "I", "This is a test sentence." | 0 |
- [X] | User enters a single letter word to match and matches exist  | "a", "This is a test sentence." | 1 | 
- [X] | User enters a multi-character word to match with matches | "test", "This is a test sentence."| 1 |
- [X] | Program can find multiple instances of the test word | "is", "This is a test sentence. It is just for testing." | 2 |
- [X] | Program ignores case when finding matches | "this", "This is a test sentence." | 1 |
- [X] | Program ignores partial matches in words | "test", "This is a test sentence. It is just for testing." | 1 |
- [X] | Program ignores punctuation when finding matches | "sentence", "This is a test sentence." | 1 |
- [X] | Program will find plural and singular versions of the word | "test", "This is a test sentence, it tests sentences." | 2 |

## Setup/Installation Requirements_

* _Clone this repository_
* _Navigate to the directory_
* _Run "dotnet run" command to open application in the command console_

## Known Bugs

_N/A_

## Support and contact details

_jasonhuels@yahoo.com_

## Technologies Used

_C#, .NET_

## Github Repo
https://github.com/jasonhuels/WordCounter

### License

*open source*

Copyright (c) 2019 **_Jason Huels_**