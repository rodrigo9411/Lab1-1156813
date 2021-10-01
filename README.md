# Lab1-1156813
Laboratorio 1 Compiladores, Rodrigo Ramirez 1156813

# Gramática

E -> E+T<br />
     E-T<br />
     T<br />
T -> T*F<br />
     T/F<br />
     F<br />
F -> (E)<br />
     -F<br />
     num
     
# Gramática Factorizada
E -> TE'<br />
E'-> +TE'<br />
     -TE'<br />
     e<br />
T -> FT'<br />
T'-> *FT'<br />
     /FT'<br />
     e<br />
F -> (E)<br />
     -F<br />
     num 
