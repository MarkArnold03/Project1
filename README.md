# Project1
Min project är en multi app Console App som inhåller en shapes app där man kan räkna ut olika shapes, en calculator och ett sten,sax,påse spel.
Alt info sparas i Data basen.
Min projekt inhåller metoder RectangleCalculation() och TriangleCalculation() osv i shapesdata som gör olika uträkningar till olika shapes.
Into de här metoderna i shapesData så använder jag av mig Istrategy som in håller konstruktor som har två parametar som tas emot i shapesServices-
som inhåller medoter som räknar ut parameterna när anropat i shapesdata.
Jag har gjort samma sak i CalculatorData där jag har använt mig av samma strategy och samma typ av konstruktor och metoder.
Jag har en metoder som  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder som spara alt från appen i Databasen.
Den metoden är i ApplicatioDbContext Classen som arver från Dbcontext Classen som säger till att skicka info ill databasen.
I både CalculatorData och ShapesData så har jag CRUD metoder som anropas i MainMenu klassen och de kan läggatill,updatera,visa eller radera infon som finns i databasen.
Jag har också en BuildApp metod som finns i BuildClassen och den bygger eller uppdaterar databasen.
I denna project så har jag seedat info från början till min databas men hjälp av code first i klassen DataInitializer där jag skickar färdig info om Shapes och calculator appen-
till dataBasen.
