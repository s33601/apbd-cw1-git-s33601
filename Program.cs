Console.WriteLine("Wprowadz liczby oddzielone przecinkami: ");
string input = Console.ReadLine();
if (string.IsNullOrEmpty(input)) {
  Console.WriteLine("Brak danych.");
  return;
}
