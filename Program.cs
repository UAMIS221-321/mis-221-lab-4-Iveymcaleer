// start main 
// lab 4: triangles 
int userChoice = GetUserChoice(); //priming read 
//while(userChoice!=3){ //condition check
	//RouteEm(userChoice);
	//userChoice = GetUserChoice(); //update read
//}
// end main 


//while(userChoice!=3) {
	RouteEm(userChoice);
	//userChoice = GetUserChoice();
//}
static int GetUserChoice() {
	DisplayMenu();
	string userChoice = Console.ReadLine();
	if(IsValidChoice(userChoice)) {
		return int.Parse(userChoice);
	}
	else return 0;
}

static void DisplayMenu() {
	Console.Clear();
	System.Console.WriteLine("Enter 1 to display full\nEnter 2 to display partial\nEnter 3 to exit");
}

static bool IsValidChoice(string userInput) {
	if(userInput=="1" || userInput=="2" || userInput=="3"){
		return true;
	}
	else return false;
}

static void GetFull() { // displays a solution that's 3-9 rows & has randomly generated rows 
	Random rnd = new Random();
	int number = rnd.Next(3,10); 
	for(int row = 0; row < number ; row++) { 
		for(int col = 0; col < row; col++) {
			Console.Write(0);
		}
	Console.WriteLine();
	}
}

static void GetPartial() { 
	Random rnd = new Random(); 
	int number = rnd.Next(3,10);

	for(int row = 0; row < number ; row++) {
		for(int col = 0; col <=row; col++) {
			Random rmd = new Random(); 
			int num = rmd.Next(2);
			if(num==0) {
				Console.Write(0);
			}else {
				Console.Write("");
			}
		}
	Console.WriteLine();
	}
}

static void SayInvalid() {
	Console.WriteLine("Invalid!");
	PauseAction();
}

static void RouteEm(int menuChoice) {
	if(menuChoice==1) {
		GetFull();
	}
	else if(menuChoice==2) {
		GetPartial();
	}
	else if(menuChoice!=3) {
		SayInvalid();
	}
}

static void PauseAction() {
	System.Console.WriteLine("Press any key to continue..");
	Console.ReadKey(); 
	}



