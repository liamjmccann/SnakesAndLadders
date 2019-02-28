[![Build Status](https://travis-ci.com/liamjmc/SnakesAndLadders.svg?branch=master)](https://travis-ci.com/liamjmc/SnakesAndLadders)

## Snakes And Ladders

The initial implementation of a Snakes And Ladders game as part of a job application.

## Spec

Must be able to move a token across the board using dice rolls. Players will need to roll a dice, move their token the number of squares indicated by the dice roll and should win if they land on the final square. This can be found in more detail under the Feature 1 heading [here](http://agilekatas.co.uk/katas/SnakesAndLadders-Kata).

## Tech/framework used

<b>Built with</b>
- C#
- .NET Framework
- MSTest

## Approach

A class library has been implemented in order to satisy the minimum requirements given.

## Design 

A public class has been created for the Player and Token objects. These contain the relevant properties and simple functions to take a turn and move respectively. 

A constants class contains the winning square number. This would be used for further such constants after implementing more features.

A dice roller class implements a dice roller interface. This approach was taken so as to mock the dice roller roll function when testing this functionality.

## Tests

A number of unit tests have been created to test all of the possible public methods for each of the situations outlined in the requirements. These are implemented with MSTest and can be run in Visual Studio.

## How could the solution evolve

Methods have been implemented inside of the Player and Token classes to take a turn and move. When these become more complex the implementation of these may be moved to a service in order keep to the single resposibilty principle.

The move method is currently public so as to test the functionality as in the requirements. This may be made private as it may not be need to be publicly accessed.

A contextual class could be created in order to contain everything that is in a single game. This could include a number of players, both computer controlled or otherwise, the board and the winning player. The logic would be changed to fit within the context of the game as a whole.