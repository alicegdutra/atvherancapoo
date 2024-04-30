﻿// método Main()
using HerancaFuncionario;

Funcionario f = new Funcionario();
f.Mostrar();
Funcionario f2 = new Funcionario(001,"Liane Lins", 2500);
f2.Mostrar();

Mensalista m = new Mensalista();
m.Mostrar();
Mensalista m2 = new Mensalista(002,"Alice Dutra", 10000, 12);
m2.Mostrar();

Horista h = new Horista();
h.Mostrar();
Horista h2 = new Horista(003, "Luana Carvalho", 6000, 72);
h2.Mostrar();


//base. - chama o método 
//base() - chama o construtor