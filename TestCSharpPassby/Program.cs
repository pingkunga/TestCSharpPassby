using System;
using System.Collections.Generic;
using TestCSharpPassby.Properties;

namespace TestCSharpPassby
{
  class Program
  {
    public static void Main(string[] args)
    {
      Company company = new Company();
      company.CompanyName= "COMSWU";
      Console.WriteLine("First >> " + company.CompanyName);
      ChangeNameVer1(company);
      Console.WriteLine("Second >> " + company.CompanyName);
      ChangeNameVer2(company);
      Console.WriteLine("Third >> " + company.CompanyName);
      ChangeNameVer3(company);
      Console.WriteLine("Fourth >> " + company.CompanyName);
      //ChangeNameVer4(ref company);
      //Console.WriteLine("Fifth >> " + company.CompanyName);
      //ChangeNameVer5(ref company);
      //Console.WriteLine("Sixth >> " + company.CompanyName);
    }

    public static void ChangeNameVer1(Company pCompany)
    {
      pCompany.CompanyName = "DebuggingSoft";
    }

    public static void ChangeNameVer2(Company pCompany)
    {
      pCompany = new Company();
      pCompany.CompanyName = "Chatri Soft";
    }

    public static void ChangeNameVer3(Company pCompany)
    {
      pCompany = null;
    }

    public static void ChangeNameVer4(ref Company pCompany)
    {
      pCompany = new Company();
      pCompany.CompanyName = "Chatri Soft";
    }

    public static void ChangeNameVer5(ref Company pCompany)
    {
      pCompany = null;
    }
  }
}