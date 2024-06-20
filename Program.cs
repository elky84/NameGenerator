// 성에 대한 한국식(한글)과 유럽식(영문) 데이터
List<string> koreanLastNames = ["김", "이", "박", "최", "정", "강", "조", "윤"];
List<string> europeanLastNames = ["Smith", "Johnson", "Williams", "Jones", "Brown", "Davis"];

// 이름에 대한 한국식(한글)과 유럽식(영문) 데이터
List<string> koreanFirstNames = ["민지", "성우", "지현", "영희", "준호"];
List<string> europeanFirstNames = ["John", "Emma", "William", "Olivia", "James"];

// 무작위 조합 생성
Random random = new();

while (true)
{
    Console.WriteLine("이름 조합을 생성하려면 Enter를, 종료하려면 'quit', 'q', 또는 'Q'를 입력하세요:");
    var userInput = Console.ReadLine()?.ToLower();

    if (userInput == "quit" || userInput == "q")
        break;

    string lastName = random.Next(2) == 0 ?
        koreanLastNames[random.Next(koreanLastNames.Count)] :
        europeanLastNames[random.Next(europeanLastNames.Count)];

    string firstName = random.Next(2) == 0 ?
        koreanFirstNames[random.Next(koreanFirstNames.Count)] :
        europeanFirstNames[random.Next(europeanFirstNames.Count)];

    Console.WriteLine($"{lastName} {firstName}");
    Console.WriteLine();
}

Console.WriteLine("프로그램을 종료합니다.");