# Lab1-1156813
Laboratorio 1 Compiladores, Rodrigo Ramirez 1156813

# Gramática

E -> E+T
     E-T
     T
T -> T*F
     T/F
     F
F -> (E)
     -F
     num
     
# Gramática Factorizada
E -> TE'
E'-> +TE'
     -TE'
     e
T -> FT'
T'-> *FT'
     /FT'
     e
F -> (E)
     -F
     num 
