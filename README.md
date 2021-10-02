# Lab1-1156813
Laboratorio 1 Compiladores, Rodrigo Ramirez 1156813

Expresiones aritéticas con enteros de un solo dígito

# Gramática

E ->  E+T<br />
     &ensp;&ensp;&ensp;&ensp;E-T<br />
      &ensp;&ensp;&ensp;&ensp;T<br />
T -> T*F<br />
      &ensp;&ensp;&ensp;&ensp;T/F<br />
      &ensp;&ensp;&ensp;&ensp;F<br />
F -> (E)<br />
      &ensp;&ensp;&ensp;&ensp;-F<br />
      &ensp;&ensp;&ensp;&ensp;num
     
# Gramática Factorizada
E -> TE'<br />
E'-> +TE'<br />
      &ensp;&ensp;&ensp;&ensp;-TE'<br />
      &ensp;&ensp;&ensp;&ensp;e<br />
T -> FT'<br />
T'-> *FT'<br />
      &ensp;&ensp;&ensp;&ensp;/FT'<br />
      &ensp;&ensp;&ensp;&ensp;e<br />
F -> (E)<br />
      &ensp;&ensp;&ensp;&ensp;-F<br />
      &ensp;&ensp;&ensp;&ensp;num 
