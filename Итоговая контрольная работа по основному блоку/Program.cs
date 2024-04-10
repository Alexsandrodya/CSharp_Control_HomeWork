List<string> mass = new List<string>();
bool flag=true;
string str="";
while(flag){
    Console.WriteLine("Введите строку или нажмите q и enter для выхода");
    str=Console.ReadLine();
    if(str=="q"){
        flag=false;
    }else{
        mass.Add(str);
    }
}

Console.WriteLine($"Получилось {mass.Count} строк:");
foreach(string m in mass){
    Console.WriteLine(m);
}

List<string> new_mass=new List<string>();
foreach(string m in mass){
    if(m.Length<=3){
        new_mass.Add(m);
    }
}

Console.WriteLine($"Количество строк длина которых меньше 3 символов, равна: {new_mass.Count}");
foreach(string m in new_mass){
    Console.WriteLine(m);
}
 






