using System;


public class Configs
{
	// One year has 525600 minutes
	// Let's assume that real world 1 day = 30 seconds in game.
	public static float ONE_DAY_TIME_IN_GAME_SECONDS = 30;

	public static float getSecondsInGame(float days){
		return ONE_DAY_TIME_IN_GAME_SECONDS * days;
	}
}
