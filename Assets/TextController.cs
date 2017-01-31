using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	
	private enum States {platform, stairs, escalator, handrail, unassisted, clipper, emergency, market, stevenson, stevenson2, fight, change, elevator, stairs2, push, wait, returnPlatform};
	private States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.platform;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if 		(myState == States.platform) 		{platform();}
		else if (myState == States.stairs) 			{stairs();}
		else if (myState == States.escalator) 		{escalator ();}
		else if (myState == States.returnPlatform) 	{returnPlatform ();}
		else if (myState == States.handrail) 		{handrail ();}
		else if (myState == States.unassisted) 		{unassisted ();}
		else if (myState == States.clipper) 		{clipper ();}
		else if (myState == States.emergency) 		{emergency ();}
		else if (myState == States.market) 			{market ();}
		else if (myState == States.stevenson) 		{stevenson ();}
		else if (myState == States.stevenson2) 		{stevenson2 ();}
		else if (myState == States.fight) 			{fight ();}
		else if (myState == States.change) 			{change ();}
		else if (myState == States.elevator) 		{elevator ();}
		else if (myState == States.stairs2) 		{stairs2 ();}
		else if (myState == States.push) 			{push ();}
		else if (myState == States.wait) 			{wait ();}
	}
	
	#region State handler methods
	
	void platform () {
		text.text = "You are Kenny Tran, a front end web developer at Mesosphere, and you're hungry. " +
					"It is 10:00 AM on a Friday, and you've just stepped off your BART train.\n\n" +
					"Today is breakfast burrito Friday, and you know that by now, there aren't many " +
					"good burritos left to choose from. You must make haste.\n\n" +
					"There is a set of stairs leading up from the platform, as well as an escalator.\n\n\n" +
					"Press S to take the stairs.\n\n" +
					"Press E to take the escalator.";
		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs;}
		else if (Input.GetKeyDown(KeyCode.E)) 		{myState = States.escalator;}
	}
	
	void returnPlatform () {
		text.text = "You're back on the platform after your mishap with the escalator.\n\n\n" +
					"Press S to take the stairs.";
		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs;}
	}
	
	void stairs () {
		text.text = "You're about to eat as many burritos as you can once you get to work, so you might as well burn a few extra calories climbing the stairs.\n\n\n" +
					"Press H to hold on to the handrail as you climb.\n\n" +
					"Press U to climb unassisted.";
		if 		(Input.GetKeyDown(KeyCode.H)) 		{myState = States.handrail;}
		else if (Input.GetKeyDown(KeyCode.U)) 		{myState = States.unassisted;}
	}
	
	void escalator () {
		text.text = "You approach the escalator and realize after stepping onto the first step that the escalator is going down. Several people bump into you, cursing and pushing you. You're not sure why you chose to go this way.\n\n\n" +
					"Press R to return to the platform.";
		if 		(Input.GetKeyDown(KeyCode.R)) 		{myState = States.returnPlatform;}
	}
	
	void handrail () {
		text.text = "You reach out to grab the handrail, and slide it along as you ascend. As you get closer to the top of the stairs, you feel faint, and eventually fall over in a heap.\n\n" +
					"You are dead.\n\n" +
					"The handrails in BART stations are disgusting and covered in germs. You should have known better.\n\n\n" +
					"Press P to play again.";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.platform;}
	}
	
	void unassisted () {
		text.text = "You know better than to touch anything in the BART station. Even a handrail. You bound up the steps, two at a time, and squeeze past an old lady. After turning a corner, you're in front of the fare gates.\n\n" +
					"You notice there is a very long line for the fare gates. But there is nobody near the emergency exit...\n\n\n" +
					"Press C to find your Clipper card in your wallet and use it.\n\n" +
					"Press E to try to sneak through the emergency exit.";
		if 		(Input.GetKeyDown(KeyCode.C)) 		{myState = States.clipper;}
		else if (Input.GetKeyDown(KeyCode.E)) 		{myState = States.emergency;}
	}
	
	void clipper () {
		text.text = "You pat around and find your wallet in your back pocket, and place it on the Clipper logo, after waiting your turn. The fare gates open and the screen displays your remaining balance. Sixty-nine cents.\n\n" +
					"\"Nice.\" you say quietly to yourself.\n\n" +
					"You continue your journey to the surface, onto Market street. There are two entrances to the Mesosphere office.\n\n\n" +
					"Press M to take the Market Street entrance.\n\n" +
					"Press S to take the Stevenson Street entrance.";
		if 		(Input.GetKeyDown(KeyCode.M)) 		{myState = States.market;}
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.stevenson;}
	}
	
	void emergency () {
		text.text = "You attempt to sneak through the emergency exit gate right next to an alert BART station agent. Unfortunately, this one seems to actually give a shit for once and calls for the BART police.\n\n" +
					"You are arrested.\n\n" +
					"You've seen many people skip the fare even in front of station agents, but you couldn't get away with it yourself. Now you'll never get a burrito.\n\n\n" +
					"Press P to play again.";
		if (Input.GetKeyDown(KeyCode.P)) 			{myState = States.platform;}
	}
	
	void market () {
		text.text = "You walk past Peet's to the Market Street entrance, where you are greeted by an angry, raving homeless man blocking the door. He has a cup with some change in it.\n\n\n" +
					"Press S to try the Stevenson Street entrance instead.\n\n" +
					"Press F to fight the homeless man.\n\n" +
					"Press C to give the homeless man some change.";
		if 		(Input.GetKeyDown(KeyCode.S)) 		{myState = States.stevenson2;}
		else if (Input.GetKeyDown(KeyCode.F)) 		{myState = States.fight;}
		else if (Input.GetKeyDown(KeyCode.C)) 		{myState = States.change;}
	}
	
	void stevenson () {
		text.text = "You head for the Stevenson Street entrance, but are ran over by Alyssa in her white Jeep.\n\n\n" +
					"You are dead.\n\n\n" +
					"Press P to play again.";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.platform;}
	}
	
	void stevenson2 () {
		text.text = "You turn around and head for the Stevenson entrance instead. Hopefully this will only result in a short delay before you can acquire your burritos. As you round the corner, you see Alyssa handing her keys to a Luxe attendant.\n\n" +
					"There are two doors to the Mesosphere office on the Stevenson Street entrance. You need to get to the third floor, where you know the burritos await you.\n\n\n" +
					"Press E to use the left door that leads to the elevator.\n\n" +
					"Press S to use the right door that leads to the stairs.";
		if 		(Input.GetKeyDown(KeyCode.E)) 		{myState = States.elevator;}
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs2;}
	}
	
	void fight () {
		text.text = "You attempt to fight the homeless man, who quickly overpowers you with unexpected strength and stench.\n\n" +
					"You are dead.\n\n\n"  +
					"Press P to play again.";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.platform;}
	}
	
	void change () {
		text.text = "You search for some change in your pocket and deposit it in the homeless man's cup. He mumbles something and steps aside, granting you access to the entrance. You badge in and make your way to the Mesosphere office basement. You need to get to the third floor, where you know the burritos await you.\n\n\n" +
					"Press E to take the elevator.\n\n" +
					"Press S to take the stairs.";
		if 		(Input.GetKeyDown(KeyCode.E)) 		{myState = States.elevator;}
		else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.stairs2;}
	}
	
	void elevator () {
		text.text = "You press the elevator button, but it never comes. You eventually wither away and die.\n\n" +
					"You are dead.\n\n\n" +
					"Press P to play again.";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.platform;}
	}
	
	void stairs2 () {
		text.text = "You start to bound up the stairs, but Jesse is in the way, carefully attempting to descend the stairs carrying two lattes while whistling a Carly Rae Jepsen song. This is the final boss. He is delaying your quest for burritos.\n\n\n" +
					"Press P to push Jesse out of the way.\n\n" +
					"Press W to wait for Jesse to pass you before proceeding.";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.push;}
		else if (Input.GetKeyDown(KeyCode.W)) 		{myState = States.wait;}
	}
	
	void push () {
		text.text = "You push Jesse out of the way, making him tumble down the stairs. You watch the lattes splash all over the stairs and Jesse himself. You feel kind of bad. But it had to be done. You make your way to the kitchen, where you see that there are only two burritos left.\n\n" +
					"You take both. You are Kenny Tran, after all.\n\n\n" +
					"You win! Press P to play again.";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.platform;}
	}
	
	void wait () {
		text.text = "You patiently wait for Jesse to pass. It seems to take an eternity, but you do notice how nice the latte art is. After the coast is clear, you make your way to the kitchen.\n\n" +
					"There are no burritos left. You waited too long. You starve to death.\n\n" +
					"You are dead.\n\n\n" +
					"Press P to play again.";
		if 		(Input.GetKeyDown(KeyCode.P)) 		{myState = States.platform;}
	}
	
	#endregion
}
