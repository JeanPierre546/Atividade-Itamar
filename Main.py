from firebase import firebase

varloop=10
varloop02=10
varloop22=10
varloop03=10
varloop04=10
while (varloop!=0):
    print("0 - Cancelar Cadastro \n1 - Cadastrar cliente\n2 - Ler dados\n3 - Atualizar dados\n4 - Deletar dados")
    varloop = int(input("Escolha:"))
    if(varloop == 0):
        break
    if(varloop == 1):
        while(varloop02!=0):
            varNome = input("Nome do cliente:")
            varEmail = input("Email do cliente:")
            varTelefone = input("Telefone do cliente:")
            firebase01 = firebase.FirebaseApplication("https://banco-python-4205b-default-rtdb.firebaseio.com/", None)
            data = {
                'Name': varNome,
                'email': varEmail,
                'telefone': varTelefone
            }
            result01 = firebase01.post('https://banco-python-4205b-default-rtdb.firebaseio.com/atividade', data)
            print(result01)
            break
    if(varloop == 2):
        while(varloop!=0):
            varIDdoBancoLer = input("ID do Banco:")
            firebase02 = firebase.FirebaseApplication("https://banco-python-4205b-default-rtdb.firebaseio.com/", None)
            result02 = firebase02.get('/atividade/', varIDdoBancoLer)
            print(result02)
            break
    if(varloop == 3):
        while(varloop03!=0):
            varIDdoBanco = input("ID do banco para atualizar:")
            varNomeBanco = input("Qual vai atualizar:")
            varAtualizar = input("Dado para atualizar:")
            firebase03 = firebase.FirebaseApplication("https://banco-python-4205b-default-rtdb.firebaseio.com/", None)
            firebase03.put('/atividade/'+varIDdoBanco, varNomeBanco, varAtualizar)
            print("Record Updated")
            break
    if(varloop == 4):
        while(varloop04!=0):
            varIDdoBancoDelete = input("ID do banco para deletar:")
            firebase04 = firebase.FirebaseApplication("https://banco-python-4205b-default-rtdb.firebaseio.com/", None)
            firebase04.delete('/atividade/', varIDdoBancoDelete)
            print("Record deleted")
            break