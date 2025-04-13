using Petshop.Modelos;
Dono Tutor = new Dono("joao", 15);
Pet Cachorro = new Pet("Cachorro", 15, Tutor);
Medico Medico1 = new Medico("Felipe", "123213");

Consulta consulta1 = new Consulta("Consulta cachorro", Medico1, Cachorro, "Cachorro está doebte");


consulta1.MostrarConsulta();