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
*Preguntar nombre y edad
->Nombre
*[Motivo de la consulta]
->Motivo_De_La_Consulta
*Asiento
->Ofrecer_Asiento



===Nombre

"Dígame su nombre, por favor."

"Julia Barreda." 

"¿Cuántos años tiene, Julia?" 
 { not Ofrecer_Asiento : Se sienta }
"Tengo 36 años."
*[Motivo de la consulta]
->Motivo_De_La_Consulta

===Ofrecer_Asiento
-Siéntese por favor.
El paciente se sienta 
* [Motivo de la consulta]
-> Motivo_De_La_Consulta
*Preguntar Nombre y edad
->Nombre




#MOTIVO DE LA CONSULTA



===Motivo_De_La_Consulta 
¿Cuál es el motivo de su consulta?

PACIENTE: Pues verá, yo hace mucho que no vengo al médico, pero desde hace unos meses me siento muy cansada, a nada que hago me canso. Y es que soy incapaz de hacer nada, cuanto mas avanza el día peor es. 

*Preguntar alergias 
->Alergias
*Preguntar por sus antecedentes personales 
->Antecedentes_personales
*Preguntar por sus antecedentes familiares 
->Antecedentes_familiares 
*Preguntar por medicación actual 
->Medicacion_actual
*Preguntar por su estilo de vida 
->Estilo_de_vida
*Preguntar por su enfermedad actual 
->Enfermedad_actual 

*Terminar consulta
->Terminar_consulta 









#ALERGIAS

===Alergias 
¿Tiene uted alguna alergia?

PACIENTE: No que yo sepa. 
*[Alergias a medicamentos]
->Alergias_Medicamentos
*Indagar en alergias
->Indagar_Alergias
*[Volver]
->Motivo_De_La_Consulta
===Indagar_Alergias

"¿No tiene alergia al polen, a los perros...?"

PACIENTE: Nada de eso. 
*[Seguir indagando en alergias]
->Indagar_Alergias_2
*[Alergias a medicamentos]
->Alergias_Medicamentos
*[Volver]
->Motivo_De_La_Consulta

===Indagar_Alergias_2
"¿A algún insecto, alguna sustancia...?"
El paciente le interrumpe
PACIENTE:Ya le he dicho que no.
*[Alergias a medicamentos]
->Alergias_Medicamentos
*[Volver]
->Motivo_De_La_Consulta

===Alergias_Medicamentos
Preguntar si tiene alergía a algún medicamento. 
¿Tiene alergia a algún medicamento?

PACIENTE: Tampoco 
*[Volver]
->Motivo_De_La_Consulta










#ANTECEDENTES PERSONALES

                          ===Antecedentes_personales  

¿Ha tenido alguna enfermedad grave?

PACIENTE: Bueno, tuve la varicela cuando tenía 5 años pero nada más. 
*[Preguntar por Hábitos tóxicos]
->Habitos_toxicos
*[Preguntar si ha tenido alguna cirugía previa.] 
->Cirugia_previa 
*[Preguntar por vacunas]
->Vacunacion
*[Preguntar AP Ginecológicos]
->AP_ginecologicos
*[Volver]
->Motivo_De_La_Consulta






===Habitos_toxicos
*[Formalmente]
->Preguntar_Formalmente
*[Preguntar sutilmente]
->Preguntar_Sutilmente
*[Preguntar amigablemente]
->Preguntar_amigablemente
===Preguntar_Formalmente

"¿Y suele tomar alcohol o alguna sustancia tóxica?"

PACIENTE:De vez en cuando bebo algo de vino en las cenas.

"¿Tabaco?"

PACIENTE:No.


*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa

*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos



*[Volver]
->Motivo_De_La_Consulta




===Preguntar_Sutilmente
"¿Y sueles...bueno, beber... o tomar alguna sustancia nociva?"

PACIENTE:¿A qué se refiere? 
*[Preguntar formalmente]
->Preguntar_Formalmente
*[Preguntar amigablemente]
->Preguntar_amigablemente

*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa

*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos
*[Volver]
->Motivo_De_La_Consulta

===Preguntar_amigablemente
Y cuéntame, ¿bebes de vez en cuando?
¿Alguna cerveza por ahí, tabaco?

MMM...no, sólo bebo algo de vino cuando ceno.

*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa

*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos
*[Volver]
->Motivo_De_La_Consulta

===Cirugia_previa 
"¿Le han operado alguna vez?"

PACIENTE:Me operaron de apendicitas cuando era niña. 

*{not Habitos_toxicos}[Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos

*[Volver]
->Motivo_De_La_Consulta




===Vacunacion
"¿Sabe usted si tiene todas las vacunas puestas?"


PACIENTE:Yo diría que sí.
*[Preguntar cuando se vacunó]
->Cuando_se_vacuno

*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa
*{not Habitos_toxicos} [Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos
*[Volver]
->Motivo_De_La_Consulta

===Cuando_se_vacuno
Paciente:Ehhh... pués no lo sé, ¿Importa eso?
*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa
*{not Habitos_toxicos} [Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos
*[Volver]
->Motivo_De_La_Consulta



===AP_ginecologicos
"¿Cómo es su periodo?"

PACIENTE:Pues cada 28 días y me suelen durar 4.

*{not Gestaciones}[Preguntar por gestaciones]
->Gestaciones
*{not FUR}[Preguntar FUR]
->FUR
*{not Anticonceptivos}[Preguntar anticonceptivos]
->Anticonceptivos

*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa
*{not Habitos_toxicos} [Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion
*[Volver]
->Motivo_De_La_Consulta


===FUR
"¿Cuando tuvo la última regla?"

PACIENTE:No lo recuerdo.

*{not Gestaciones}[Preguntar por gestaciones]
->Gestaciones
*{not Anticonceptivos}[Preguntar anticonceptivos]
->Anticonceptivos

*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa
*{not Habitos_toxicos} [Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion

*[Volver]
->Motivo_De_La_Consulta


===Anticonceptivos
"¿Usa algún anticonceptivo?"

PACIENTE:Si, tengo puesto un DIU.

*{not Gestaciones}[Preguntar por gestaciones]
->Gestaciones
*{not FUR}[Preguntar FUR]
->FUR

*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa
*{not Habitos_toxicos} [Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion

*[Volver]
->Motivo_De_La_Consulta


===Gestaciones
"¿Ha estado embarazada?"

PACIENTE:Si, dos veces

*[Preguntar por abortos]
->Abortos
*{not FUR}[Preguntar FUR]
->FUR
*{not Anticonceptivos}[Preguntar anticonceptivos]
->Anticonceptivos

*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa
*{not Habitos_toxicos} [Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos

*[Volver]
->Motivo_De_La_Consulta


===Abortos
"¿Y ha tenido algún aborto?"

PACIENTE:No.

*[Indagar en abortos]
->Indagar_abortos
*{not FUR}[Preguntar FUR]
->FUR
*{not Anticonceptivos}[Preguntar anticonceptivos]
->Anticonceptivos


*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa
*{not Habitos_toxicos} [Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos

*[Volver]
->Motivo_De_La_Consulta


===Indagar_abortos

"¿Y fue todo perfecto durante el embarazo?"

Paciente:Yo diría que sí...
         Bueno, tuve un problema con el azucar durante el segundo embarazo, pero no hizo falta tratamiento, solo me mandaron una dieta.
         
*{not FUR}[Preguntar FUR]
->FUR
*{not Anticonceptivos}[Preguntar anticonceptivos]
->Anticonceptivos

*{not Cirugia_previa} [Cirugía previa]
->Cirugia_previa
*{not Habitos_toxicos} [Preguntar por hábitos tóxicos.] 
->Habitos_toxicos
*{not Vacunacion}[Preguntar por vacunas]
->Vacunacion
*{not AP_ginecologicos}[Preguntar AP Ginecológicos]
->AP_ginecologicos

*[Volver]
->Motivo_De_La_Consulta






#MEDIACION ACTUAL

                               ===Medicacion_actual

"¿Está tomando algún fármaco actualmente?"

PACIENTE:No, ahora no estoy tomando nada de la farmacia.

*[Productos de herbolario]
->Productos_herbolario

===Productos_herbolario
"¿Toma algo del herbolario?"

PACIENTE:¡Ah, sí! Estoy tomando melisa y pasiflora para dormir.

*[Volver]
->Motivo_De_La_Consulta
#ANTECEDENTES FAMILAIRES



                                ===Antecedentes_familiares

"Hábleme de su familia"

*[Problemas de salud relevantes]
->Problemas_Salud_Relevantes
*[Enfermedad cardiovascular precoz]
->Enfermedad_cardiovascular

*[Volver]
->Motivo_De_La_Consulta

===Problemas_Salud_Relevantes
"¿Hay alguien de su familia que tenga algún problema de salud?"

PACIENTE:Mi madre es diábetica y ahora está empeando a tener algunos problemas de memoria mas graves.
*{ not Enfermedad_cardiovascular} [Enfermedad cardiovascular precoz]
->Enfermedad_cardiovascular
*{not Padre} [Padre]
->Padre
*{not Cancer}[Cáncer]
->Cancer

*[Volver]
->Motivo_De_La_Consulta


===Enfermedad_cardiovascular
"¿Ha habido alguna enfermedad cardiovascular en su familia?"

PACIENTE:No
*{not Problemas_Salud_Relevantes}[Problemas de salud relevantes]
->Problemas_Salud_Relevantes
*{not Padre} [Padre]
->Padre
*{not Cancer}[Cáncer]
->Cancer

*[Volver]
->Motivo_De_La_Consulta

===Padre
"¿Y su padre qué tal está?"
PACIENTE:Bueno mi padre está anticoagulado por un par de episodios que tuvo de tromboembolismo pulmonar.

*[Indagar]
->Indagar_Padre
*{ not Parientes}[Otros parientes]
->Parientes
*{ not Enfermedad_cardiovascular} [Enfermedad cardiovascular precoz]
->Enfermedad_cardiovascular
*{not Cancer}[Cáncer]
->Cancer

*[Volver]
->Motivo_De_La_Consulta

===Indagar_Padre
"¿Cuál era el origen del tromboembolismo?"

PACIENTE:No lo saben.
*{ not Parientes}[Otros parientes]
->Parientes
*{ not Enfermedad_cardiovascular} [Enfermedad cardiovascular precoz]
->Enfermedad_cardiovascular
*{not Problemas_Salud_Relevantes}[Problemas de salud relevantes]
->Problemas_Salud_Relevantes

*[Volver]
->Motivo_De_La_Consulta

===Parientes
"¿No tiene mas parientes?"

PACIENTE:Tengo una hermana, que tiene también diabetes, pero no se si tiene algún tratamiento, no nos vemos mucho. 

*{not Padre} [Padre]
->Padre
*{ not Enfermedad_cardiovascular} [Enfermedad cardiovascular precoz]
->Enfermedad_cardiovascular

*[Volver]
->Motivo_De_La_Consulta

===Cancer
"¿Alguien de su familia tiene o ha tenido cancer?"
PACIENTE:Por suerte, que yo sepa, no.

*[Volver]
->Motivo_De_La_Consulta










#ESTILO DE VIDA


                                 ===Estilo_de_vida

*{not Trabajo}[Trabajo,horario]
->Trabajo
*{not Dieta}[Dieta]
->Dieta
*{not Ejercicio}[Ejercicio]
->Ejercicio
*{not Entorno}[Relación entorno familiar]
->Entorno
*{not Mascotas}[Mascotas]
->Mascotas

*[Volver]
->Motivo_De_La_Consulta

===Trabajo
"¿Cuál es su trabajo?" 

PACIENTE:Soy profesora de secundaria. 

"¿Tiene algún horario en específico?"

PACIENTE:Trabajo en horario de mañana. De 9 a 13. 

*{not Dieta}[Dieta]
->Dieta
*{not Ejercicio}[Ejercicio]
->Ejercicio
*{not Entorno}[Relación entorno familiar]
->Entorno
*{not Mascotas}[Mascotas]
->Mascotas


*[Volver]
->Motivo_De_La_Consulta


===Dieta
"¿Qué suele comer habitualmente?" 

PACIENTE:La verdad es que como un poco de todo. 

"¿Y cuántas comidas realiza al día?" 

PACIENTE:Habitualmente 3. Desayuno, comida y cena, aunque a veces también meriendo algo. 

*{not Trabajo}[Trabajo,horario]
->Trabajo
*{not Ejercicio}[Ejercicio]
->Ejercicio
*{not Entorno}[Relación entorno familiar]
->Entorno
*{not Mascotas}[Mascotas]
->Mascotas

*[Volver]
->Motivo_De_La_Consulta


===Ejercicio
"¿Realiza algún tipo de ejercicio?" 

PACIENTE:La verdad es que no. Hace tiempo intenté apuntarme a un gimnasio, pero soy demasiado perezosa y lo dejé. 

*{not Trabajo}[Trabajo,horario]
->Trabajo
*{not Dieta}[Dieta]
->Dieta
*{not Entorno}[Relación entorno familiar]
->Entorno
*{not Mascotas}[Mascotas]
->Mascotas

*[Volver]
->Motivo_De_La_Consulta


===Entorno

"Cuénteme más sobre su familia." 

PACIENTE:Actualmente vivo con mi marido y mis dos hijas, Sara y Paula. 

"¿Tienen una buena relación?" 

PACIENTE:Sí, por supuesto. 

*[Preguntar la edad de las hijas]
->Hijas

*{not Trabajo}[Trabajo,horario]
->Trabajo
*{not Dieta}[Dieta]
->Dieta
*{not Mascotas}[Mascotas]
->Mascotas
*{not Ejercicio}[Ejercicio]
->Ejercicio


*[Volver]
->Motivo_De_La_Consulta

===Hijas
"¿Qué edad tienen Sara y Paula?" 

PACIENTE:12 y 9 años respectivamente.

*{not Trabajo}[Trabajo,horario]
->Trabajo
*{not Dieta}[Dieta]
->Dieta
*{not Ejercicio}[Ejercicio]
->Ejercicio
*{not Entorno}[Relación entorno familiar]
->Entorno
*{not Mascotas}[Mascotas]
->Mascotas

*[Volver]
->Motivo_De_La_Consulta

===Mascotas
"¿Tiene alguna mascota?" 

PACIENTE: No, no me gustan mucho los animales.

*{not Trabajo}[Trabajo,horario]
->Trabajo
*{not Dieta}[Dieta]
->Dieta
*{not Ejercicio}[Ejercicio]
->Ejercicio
*{not Entorno}[Relación entorno familiar]
->Entorno

*[Volver]
->Motivo_De_La_Consulta







#ENFERMEDAD ACTUAL



                                ===Enfermedad_actual

Vale, cuénteme...
*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta


===Como
"¿Cómo empezó el cansancio?"

PACIENTE:No sabría decirte exactamente. Solo sé que un día emepecé a notar un gran cansancio que en algunas ocasiones me impedía ir al trabajo. 

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta


===Cuando
"¿Desde cuando le viene sucediendo?"

PACIENTE:Hace más o menos un mes.

*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta


===Dolor
"¿Siente algún tipo de dolor en el pecho o en el abdomen?" 

PACIENTE:No.

*[Insistir en dolencia]
->Insistir_dolencia

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta


===Insistir_dolencia

"¿Ni en la cabeza o la zona lumbar?" 

PACIENTE: No, no siento ningún tipo de dolor en ninguna parte del cuerpo. 

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta

===Caracteristicas
"¿Cómo es el cansancio? Descríbalo." 

PACIENTE:No sabría cómo explicarle... Es un cansancio pesado, que se va acentuando a medida que pasa el día.

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta

===Factores

"¿Nota que la fatiga disminuya tras realizar alguna actividad o es persistente?"

PACIENTE:Después de descansar un rato me encuentro algo mejor.

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta

===Sintomas

"¿Tiene algún otro síntoma a parte de los ya mencionados?"

PACIENTE:Como ya le he dicho, tengo mucho cansancio. Además he perdido 4 kilos incluso comiendo más que antes.

*[Indagar en síntomas]
->Indagas_sintomas

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta

===Indagas_sintomas

"¿Algún otro síntoma que haya notado?" 

PACIENTE:Bueno... A veces noto un cierto olor afrutado en mi aliento y no sé porque es. 

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Atribuye}[A que lo atribuye]
->Atribuye
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta

===Atribuye

"¿De qué crees que se pueda tratar?" 

PACIENTE: Pues sinceramente, yo vine con la idea de que a lo mejor se trataba de un cáncer de mama. 

"¿Y por qué creía eso?" 

PACIENTE: Es que a una amiga mía se lo detectaron hace no mucho. Y hablando, ella me comentó que también siente cansancio y ha adelgazado bastante. 

*[Mostrar preocupación]
->Mostrar_preocupacion
*[Mostrar empatía]
->Mostrar_empatia

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta

===Mostrar_preocupacion

"No te preocupes. Que tu amiga tenga cáncer no sifnifica que tú lo vayas a tener." 
#-2 confortabilidad

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta

===Mostrar_empatia

"Entiendo su preocupación. Si quiere a parte de las pruebas normales, puedo mandarte a hacer una mamografía." 

PACIENTE: Eso me dejaría mucho más tranquila, gracias.

#+2 CONFORTABLIDAD

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta

===Repercusion

"¿Qué repercusión a tenido en su día a día?" 

PACIENTE:Me cuesta mucho realizar mis actividades habituales, sobre todo por la tarde. A veces llego tan mal a casa que me cuesta ayudar a mis hijas con los deberes.

*{not Como}[Cómo empezó]
->Como
*{not Cuando}[Desde cuándo le sucede esto]
->Cuando
*{not Dolor}[Como es el dolor]
->Dolor
*{not Caracteristicas}[Características]
->Caracteristicas
*{not Factores}[Factores que alivian o empeoran]
->Factores
*{not Sintomas}[Síntomas asociados]
->Sintomas
*{not Repercusion}[Repercusión es su vida normal]
->Repercusion

*[Volver]
->Motivo_De_La_Consulta


#TERMINAR CONSULTA




                                ===Terminar_consulta 
"Bueno, pues con todos estos datos, creo que podemos dar por terminada la consulta. Le pasaré la información a mi tutor y en unos días nos pondremos en contacto contigo para darte los resultados."

PACIENTE: ¿Y qué puedo hacer mientras tanto? 

*[Recomendar reposo]
"Te recomendaría hasta entonces reposo. Intentaremos darle los resultados definitivos lo antes posible."
PACIENTE: De acuerdo, muchas gracias doctor. 

**Despedida cordial 
->Cordial 
**Despedida formal 
->Adios_Formal
*[Calmar]
"No se preocupe, espere a que le demos los resultados." 
PACIENTE: Está bien... 

"No puede hacer nada más, lo siento."  

**[Despedida cordial] 
->Cordial
**[Despedida formal] 
->Adios_Formal

===Cordial 
Bueno, pues ya te informaremos cuando obtengamos los resultados. Cualquier cosa que necesite, Julia, pasese por la consulta. Hasta pronto. 
->END

===Adios_Formal
Bueno pues nos vemos pronto. Nos pondremos en contacto con usted cuando tengamos los resultados. Adiós. 
->END

