using Library;
using System;
using NUnit.Framework;

namespace Library.Tests;

/* Hacer uno o más casos de prueba que comprueben que la función está bien implementada. 
Incluye casos de prueba para, al menos, los siguientes casos:
- Una fecha en formato correcto
- Una fecha que no tenga el formato correcto
- Una fecha en blanco
*/

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectFormatDate()
    {
        //Configuración
        const string expectedDate1 = "1997-11-10";
        const string inputDate = "10/11/1997";
        //Ejecución 
        string correct_format_date = DateFormatter.ChangeFormat(inputDate);
        //Comprobación
        Assert.AreEqual(expectedDate1, correct_format_date);
    }

    [Test]
    public void IncorrectFormatDate()
    {
        //Configuración
        const string expectedDate2 = null;
        const string inputDate = "10/11-1997";
        //Ejecución 
        string incorrect_format_date = DateFormatter.ChangeFormat(inputDate);
        //Comprobación
        Assert.AreEqual(expectedDate2 , incorrect_format_date);
    }

    [Test]
    public void DateIsNullorEmpty()
    {
        //Configuración
        const string emptyDate = "";
        //Ejecución 
        string null_or_empty_date = DateFormatter.ChangeFormat(emptyDate);
        //Comprobación
        Assert.IsNull(null_or_empty_date);
    }
}

   