using System.Windows.Forms;
using Microsoft.VisualBasic;
using System;

class enteringInteger
{
    //static void Main()
    //{
    //    string res, txt;
    //    int year = 2019, age, born;
    //    res = Interaction.InputBox("В каком году Вы родились?", "Год рождения");
    //    born = Int32.Parse(res);
    //    age = year - born;
    //    txt = "Тогда Вам " + age + " лет.";
    //    MessageBox.Show(txt, "Возраст");
    //}
}

class EnterNameAndSurname
{
    static void Main()
    {
        string name, surname, res;
        name = Interaction.InputBox("Введите ваше имя", "Name");
        surname = Interaction.InputBox("Введите вашу фамилию", "Surname");
        res = "Вас зовут " + name + ' ' + surname;
        MessageBox.Show(res, "Your name is ...");
    }
}

