using System;
using System.Collections.Generic;

class Data {
  DateTimeOffset data = DateTimeOffset.Now;

  private List<string> guardaDatas = new List<string>();
  private string dia;
  private string mes;
  private string ano;

  public Data(){
    this.dia = data.Day.ToString();
    this.mes = data.Month.ToString();
    this.ano = data.Year.ToString();
  }

  public Data(string dia,string mes,string ano) {
    this.dia = dia;
    this.mes= mes;
    this.ano= ano;
  }
  public int returnTamanho(){
    return this.guardaDatas.Count;
  }

  public string getDia(){
    return this.dia;
  }
  public string getMes(){
    return this.dia;
  }
  public string getAno(){
    return this.dia;
  }

  public void setDia(string dia){
    this.dia = dia;
  }

  public void setMes(string mes){
    this.mes = mes;
  }

  public void setAno(string ano){
    this.dia = ano;
  }

  public void addDatas(string data){
    this.guardaDatas.Add(data);
  }

  public void returnDataAtual(){
    Console.WriteLine("----- Data Atual -----");
    Console.WriteLine("Data Completa: {0}/{1}/{2}",this.dia,this.mes,this.ano);
    Console.WriteLine("----------------------");
  }

  public void avancaDia(){
    int dataInt = int.Parse(this.dia) + 1;
    this.dia = dataInt.ToString();
    returnDataAtual();
  }
}