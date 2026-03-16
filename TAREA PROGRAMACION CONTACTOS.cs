static void SearchContact(
    List<int> ids,
    Dictionary<int, string> names,
    Dictionary<int, string> lastnames,
    Dictionary<int, string> addresses,
    Dictionary<int, string> telephones,
    Dictionary<int, string> emails,
    Dictionary<int, int> ages,
    Dictionary<int, bool> bestFriends)
{
    Console.Write("\nDigite el nombre a buscar: ");
    string searchName = Console.ReadLine();

    bool found = false;

    foreach (var id in ids)
    {
        if (names[id].ToLower().Contains(searchName.ToLower()))
        {
            string isBestFriendStr = bestFriends[id] ? "Sí" : "No";

            Console.WriteLine(
                $"ID: {id} | {names[id]} {lastnames[id]} | " +
                $"{addresses[id]} | {telephones[id]} | " +
                $"{emails[id]} | Edad: {ages[id]} | Mejor Amigo: {isBestFriendStr}"
            );

            found = true;
        }
    }

    if (!found)
    {
        Console.WriteLine("No se encontraron resultados.");
    }
}

case 3:
    SearchContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
    break;


    static void UpdateContact(
    List<int> ids,
    Dictionary<int, string> names,
    Dictionary<int, string> lastnames,
    Dictionary<int, string> addresses,
    Dictionary<int, string> telephones,
    Dictionary<int, string> emails,
    Dictionary<int, int> ages,
    Dictionary<int, bool> bestFriends)
    {
        Console.Write("\nDigite el ID del contacto a modificar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (ids.Contains(id))
        {
            Console.Write("Nuevo nombre: ");
            names[id] = Console.ReadLine();

            Console.Write("Nuevo apellido: ");
            lastnames[id] = Console.ReadLine();

            Console.Write("Nueva dirección: ");
            addresses[id] = Console.ReadLine();

            Console.Write("Nuevo teléfono: ");
            telephones[id] = Console.ReadLine();

            Console.Write("Nuevo email: ");
            emails[id] = Console.ReadLine();

            Console.Write("Nueva edad: ");
            ages[id] = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Es mejor amigo? (1 = Sí, 2 = No): ");
            bestFriends[id] = Convert.ToInt32(Console.ReadLine()) == 1;

            Console.WriteLine("Contacto actualizado correctamente.");
        }
        else
        {
            Console.WriteLine("El ID no existe.");
        }
    }

case 4:
    UpdateContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
    break;

    static void DeleteContact(
    List<int> ids,
    Dictionary<int, string> names,
    Dictionary<int, string> lastnames,
    Dictionary<int, string> addresses,
    Dictionary<int, string> telephones,
    Dictionary<int, string> emails,
    Dictionary<int, int> ages,
    Dictionary<int, bool> bestFriends)
    {
        Console.Write("\nDigite el ID del contacto a eliminar: ");
        int id = Convert.ToInt32(Console.ReadLine());

        if (ids.Contains(id))
        {
            ids.Remove(id);
            names.Remove(id);
            lastnames.Remove(id);
            addresses.Remove(id);
            telephones.Remove(id);
            emails.Remove(id);
            ages.Remove(id);
            bestFriends.Remove(id);

            Console.WriteLine("Contacto eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("El ID no existe.");
        }
    }

case 5:
    DeleteContact(ids, names, lastnames, addresses, telephones, emails, ages, bestFriends);
    break;
