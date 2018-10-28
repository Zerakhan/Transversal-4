-> Inicio

=== Inicio
El paciente entra por la puerta.
* Levantarse
     ** [Amigable]
     ->Amigable
     ** [Directo]
     ->Directo
     **[Formal]
     ->Formal
* No Levantarse

    **[Amigable]
     ->Amigable
    **[Directo]
     ->Directo
    **[Formal]
     ->Formal
   
   ===Amigable
  Buenas, adelante. ¿Qué tal? 
     ->Despues_Del_Saludo
   
   ===Directo
     (alzas la voz para que el paciente te escuche bien)
      Pase, por favor.
    ->Despues_Del_Saludo
   
   ===Formal
     Buenos días, pase por favor.
    ->Despues_Del_Saludo

   

=== Despues_Del_Saludo
*[Preguntar nombre y edad]
->Nombre
*[Motivo de la consulta]
->Motivo_De_La_Consulta
*[Ofrecer Asiento]
->Ofrecer_Asiento
 


===Nombre

"Dígame su nombre, por favor."

"Julia Barreda." 

"¿Cuántos años tiene, Julia?" 
 { Ofrecer_Asiento : PUTa }


"Tengo 36 años."
->Motivo_De_La_Consulta

===Ofrecer_Asiento
-Siéntese por favor.
El paciente se sienta 
* Motivo de la consulta
-> Motivo_De_La_Consulta
*Preguntar Nombre y edad
->Nombre




===Motivo_De_La_Consulta




-> END
