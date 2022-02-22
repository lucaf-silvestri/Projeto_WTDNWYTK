USE WTDNWYTK;
GO

INSERT INTO usuario (nome, email, senha)
VALUES
('Carl Johnson', 'cj@email.com', 'cj123'),
('Tommy Vercetti', 'tv@email.com', 'tv123'),
('Niko Bellic', 'nb@email.com', 'nb123');
GO

INSERT INTO tipo (nomeTipo) 
VALUES
('Artefato'),
('Criatura'),
('Assombra��o'),
('Local Misterioso'),
('Cad�ver'),
('Acontecimento Misterioso'),
('Alien�gena'),
('Assassino em S�rie'),
('Imposs�vel de Descrever');
GO

INSERT INTO regiao (nomeRegiao) 
VALUES
('Nuevo Para�so'),
('New Austin'),
('West Elizabeth'),
('San Andreas'),
('Los Santos'),
('Blaine County'),
('Sandy Shores'),
('Paleto Bay'),
('Monte Chiliad'),
('Whetstone'),
('Flint County'),
('Red County'),
('Tierra Robada'),
('Bone County'),
('San Fierro'),
('Las Venturas')
GO

INSERT INTO historia (idUsuario, titulo, texto, imagem1, imagem2) 
VALUES
('1', 'A M�scara Asteca', 'A m�scara asteca � um artefato m�stico amaldi�oado enterrado em uma catacumba localizada abaixo do abandonado pal�cio que pertenceu � Agustin Allende, em Escalera, Nuevo Para�so, no M�xico. A m�scara, supostamente, se retirada de seu devido lugar, pode liberar sua maldi��o sobre os seres que vivem na regi�o, assim, transformando-os em mortos-vivos, que perambulam em busca de carne para se alimentar. A maldi��o n�o afeta apenas humanos, mas tamb�m a maioria das esp�cies da fauna da regi�o.', NULL, NULL),
('1', 'O Jackalope', 'O Jackalope � uma criatura avistada em �reas de New Austin, sua apar�ncia � de um coelho com chifres. Seu comportamento � id�ntico ao de um coelho comum. ', 'jackalope.png', NULL),
('1', 'Os P�-Grandes de West Elizabeth', 'Teorias dizem que na floresta de Tall Trees, em West Elizabeth, vive uma fam�lia de p�-grandes. Supostamente, os serem vivem na regi�o por mil�nios e se alimentam de pequenas frutas e cogumelos. Seus tamanhos variam de 2 a 3 metros de altura, seus corpos s�o cobertos de pelos e, apesar de t�midos, se mostram agressivos se amea�ados. Muitos ca�adores locais afirmam j� terem avistado as criaturas perambulando pela floresta, esses descreveram olhos grandes, uma sobrancelha pronunciada e uma testa grande e baixa; o topo da cabe�a foi descrito como arredondado e com crista, semelhante � crista sagital do gorila macho. S�o comumente relatados como tendo um cheiro forte e desagrad�vel por aqueles que afirmam t�-lo encontrado. Apesar de sua apar�ncia, eles s�o muito semelhantes aos humanos em suas rea��es e sentimentos. ', 'pegrandeWE.png', NULL),
('1', 'O Chupacabra de Nuevo Para�so', 'No territ�rio de Nuevo Para�so, no M�xico, foram relatadas diversas apari��es da criatura conhecida como Chupacabra. Pouco se sabe sobre ela, com relatos indicando uma apar�ncia semelhante � de um lobo ou puma. O Chupacabra, como mostra seu nome, costuma se alimentar de cabras, se disfar�ando em seus rebanhos e atacando quando fica com fome, mordendo o pesco�o dos animais e drenando seu sangue.', NULL, NULL),
('1', 'O Unic�rnio de Nuevo Para�so', 'Al�m do Chupacabra, o territ�rio de Nuevo para�so tamb�m parece ser habitado por outra esp�cie incomum, o Unic�rnio. A criatura cavalga pela regi�o como um cavalo e se alimenta das pequenas vegeta��es do solo, mas � agressiva se amea�ada. Possui caracter�sticas muito parecidas com as de um cavalo, com a �nica diferen�a sendo um chifre em formato de cone no topo da cabe�a e um rastro colorido que solta enquanto cavalga. As principais evid�ncias de sua exist�ncia � um p� colorido desconhecido encontrado no solo da �rea (provavelmente proveniente do rastro colorido citado anteriormente) e animais ca�adores mortos por um largo furo em seus corpos, provavelmente causado por ataques do chifre do unic�rnio.', NULL, NULL),
('2', 'O P�-Grande do Mount Chiliad', 'P�-Grandes parecem ser bens comuns na Am�rica, o mito dessa vez � de certas apari��es da criatura nas florestas na parte mais baixa do Monte Chiliad, montanha localizada a oeste de Whetstone,  na parte rural de San Andreas. Esse �, com certeza, o rumor mais forte da lista, sendo que toda a popula��o que vive nas cidades pr�ximas � montanha parece estar certa de que a criatura vive ou j� viveu por l�. Suas apari��es aconteceram em sua maioria entre os anos 1990 � 1992, principalmente vivenciadas por fazendeiros, campistas ou pessoas que faziam trilhas. Em uma cabana na �rea foram encontrados restos de animais mutilados, com ferimentos que pareciam ser causados por ursos, mas sem nenhum motivo aparente de o animal ter sido assassinado na parte interna da cabana, o que leva a pensar que � um comportamento do P�-Grande. Ainda fica mais estranho com o fato de que o mesmo aconteceu em outra cabana, s� que distante do local, mais especificamente em Shady Creeks, o que pode significar que o ser n�o vivia apenas na montanha, mas perambulava por todas as florestas pr�ximas. Muitas pegadas n�o identificadas j� foram encontradas no solo das regi�es citadas. Muitos dizem que viram a criatura se movimentando por entre as �rvores, os vigiando de longe. Alguns ainda relatam apari��es at� os dias atuais, mas sem provas concretas, o que leva a pensar que apenas tentam manter a lenda viva, j� outros defendem a teoria de que a criatura morreu no ano de 1992, como nos anos seguintes houve uma quantidade de apari��es significativamente menor. De uma forma ou de outra, a exist�ncia do P�-Grande do Mount Chiliad nunca foi confirmada.', NULL, NULL),
('2', 'O Fantasma do Monte Gordo', 'Muitas testemunhas afirmam que, no topo do Monte Gordo, em Blaine County, San Andreas, pode ser avistado um fantasma flutuando sobre uma rocha. Um homem que fazia uma trilha na regi�o durante a noite comentou que viu o fantasma e, logo abaixo, uma mancha de sangue que parecia conter algo escrito, mas que quando se aproximou, ambos o fantasma e o sangue n�o estavam mais l�. � especulado que esse seja o fantasma de Jolene Evans, que morreu no local enquanto caminhava com seu marido John "Jock" Cranley, quando uma briga acabou com Jolene caindo do penhasco. Muitos afirmam que Jock empurrou a esposa, mas o homem afirma que nunca o faria.', NULL, NULL),
('2', 'P�nico nas florestas de San Andreas', 'Por todo o estado de San Andreas, foram registrados relatos de pessoas que afirmam terem experienciado um fen�meno conhecido como "P�nico na Floresta". O fen�meno supostamente acontece com pessoas que passam tempo demais nas florestas do estado. Tudo come�a com todos os sons da floresta cessando, ap�s isso, come�am a sentir paranoia, escutar um alto zumbido que n�o parece vir de lugar nenhum e avistar criaturas e sombras se movendo na vegeta��o, sempre com um constante sentimento de perigo iminente, mas todos os sintomas acabam ao retornar � civiliza��o. Alguns afirmam que o fen�meno pode ser explicado pela manifesta��o do Deus Pag�o Pan, protetor dos lugares selvagens, cuja presen�a inspira o terror. ', NULL, NULL),
('2', 'Os corpos de El Castillo del Diablo', 'Em 1992, foi encontrada por agentes do FBI uma pilha de corpos em sacos enterrada em El Castillo del Diablo, uma �rea situada no deserto de Bone County, em San Andreas. Foi confirmado pelo governo que os corpos pertencem a membros de diferentes familias mafiosas que atuavam em Las Venturas nas d�cadas de 1980 e 1990. Enterrar os corpos de seus inimigos no deserto de Bone County foi uma pr�tica muito utilizada pelas fam�lias mafiosas da �poca. A parte bizarra sobre a descoberta � o fato de os agentes terem cavado um buraco de aproximadamente 4 metros de profundidade envolta dos sacos com os corpos e o deixado aberto durante meses, com os corpos � mostra. Poucas pessoas passavam pela regi�o (principalmente pelo fato de estar pr�xima � �rea do governo conhecida como �rea 69), mas algumas testemunhas afirmaram que viram o buraco com os corpos na �poca. Algumas pessoas especulam que os corpos n�o possuem conex�es com a m�fia e seriam algum tipo de experimento dos agentes da �rea 69 e teriam at� rela��o com alien�genas, mas nada disso foi confirmado. Hoje em dia o buraco j� foi fechado. ', 'corposECDD.png', NULL),
('2', 'Os carros fantasmas de Back O Beyond', 'Mais um mist�rio das florestas de Whetstone e Flint County, dessa vez, carros fantasmas. H� uma lenda de um carro do modelo Benefactor Glendale 1991 que dirige sozinho pela floresta em Back O Beyond durante a madrugada. Algumas pessoas afirmam que viram o ve�culo se movendo e logo parando e, quando se aproximaram, perceberam que n�o havia motorista. Os relatos informam que o carro j� foi visto em diversas cores, mas sempre do mesmo modelo e com partes quebradas ou faltando. N�o existe teorias a respeito da origem do acontecimento. A imagem a seguir foi fotografada por uma testemunha do fen�meno. ', 'carrosfantasma.png', NULL),
('3', 'OVNI�s e Alien�genas em San Andreas', 'Desde a d�cada de 1980 s�o relatadas apari��es de OVNI�s e manifesta��es alien�genas em geral na �rea de San Andreas. O local que possui apari��es mais recorrentes � o deserto de Bone County, � leste de Las Venturas. UFO�s s�o os mais relatados, supostamente aparecendo em toda a parte rural do estado, de desertos a florestas. Diversos pilotos de ve�culos a�reos dizem j� terem visto os UFO�s voando em grandes alturas, alguns dizem ter visto lasers, luzes, armas e at� mesmo os pr�prios alien�genas. H� relatos de luzes tamb�m em terra, como em um caso que envolve um grupo de hippies que acampava em uma �rea no Deserto de Grand Senora que dizem ter visto as luzes enquanto fritavam hamb�rgueres durante a noite. Muitos afirmam que existe uma liga��o entre o Mist�rio do Mural do Monte Chiliad e alien�genas pelo fato de existirem desenhos que representam discos voadores espalhados pela montanha, al�m de rumores que dizem que existe um UFO no topo da montanha que fica invis�vel durante o dia, esses rumores s�o apoiados por falas de pessoas que dizem ter escutado sons estranhos enquanto faziam trilhas pelo monte. Existem diversas imagens pela internet de supostos mapas que pertencem ao governo e mostram localiza��es do estado em que as naves alien�genas podem ser avistadas. Rumores tamb�m acusam o governo dos EUA de fazerem experimentos com seres e artefatos alien�genas em suas bases militares, mais especificamente, a �rea 69, durante a d�cada de 1990 e o Fort Zancudo, mais recentemente, de 2010 at� hoje em dia. Algumas pessoas e grupos chegam a se reunir no estado de San Andreas para �ca�ar� os alien�genas e desvendar esse mist�rio, outras duvidam que os seres existam. Em 1997, um fazendeiro de Flint County informou aos jornais que extraterrestres criaram s�mbolos em sua planta��o de milho como uma forma de comunica��o, um tempo depois, confessou que ele mesmo havia criado os padr�es no milho com seu trator para chamar a aten��o da m�dia. � incerta a exist�ncia desses seres, mas esse mist�rio, juntamente com o P�-Grande do Mount Chiliad, � um dos mais comentados pela popula��o. ', 'ufo.png', 'ufo2.png'),
('3', 'A cidade mal-assombrada de Tumbleweed', 'H� relatos de diversas testemunhas que afirmam que presenciaram atividades paranormais e apari��es de fantasmas na cidade conhecida como Tumbleweed, localizada em Gaptooth Ridge, no estado de New Austin. Essa foi uma das primeiras cidades da regi�o no in�cio do s�culo XX, e suas constru��es ainda est�o de p� at� os dias de hoje, pelo fato de n�o ser uma �rea apropriada para a constru��o de uma cidade moderna, ou simplesmente pelo medo da popula��o a respeito de suas lendas. A cidade foi abandonada no in�cio do s�culo passado, com a constru��o da estrada para Armadillo,  outra cidade mais desenvolvida, o que causou o deslocamento da popula��o de Tubleweed para l�. Ap�s a desocupa��o da �rea, Tumbleweed foi utilizada como esconderijo para criminosos ap�s o fim do per�odo do velho-oeste, consequentemente, foi palco de diversos crimes, como estupros e enforcamentos por parte dos fora-da-lei. Teorias afirmam que essa � a raz�o de ser um local mal-assombrado, e que as almas das pessoas assassinadas ali permanecem na �rea at� hoje. As testemunhas das assombra��es afirmam que, ao entrar na �rea, � poss�vel escutar sussurros, latidos de cachorros, sons de carro�as, entre outros barulhos, mesmo sem haver ningu�m ali, como se ainda fosse uma cidade habitada por uma popula��o. Alguns dizem que, ao dirigir dentro da cidade, o motor do ve�culo para de funcionar. Podem ser ouvidos barulhos de algemas na delegacia e a m�sica do piano no sal�o. Mas os locais mais assustadores s�o, com certeza, a igreja e a mans�o, localizada no topo da colina mais alta da cidade. A igreja possui seu cemit�rio, onde mais s�o relatadas as atividades paranormais, e dentro da capela j� foram testemunhadas apari��es de fantasmas de pessoas andando do lado de dentro, vistas pelas janelas, e at� de dem�nios. J� para quem � corajoso o suficiente para entrar na mans�o, s�o experienciados objetos se movendo ou quebrando sozinhos, sons de gritos e passos, um frio sem explica��o, entre outros eventos. Quem entra diz que experienciou uma m� sensa��o constante, al�m de se sentirem observados. Quem olha para a mans�o de uma certa dist�ncia, pode avistar figuras fantasmag�ricas de pessoas nas janelas do segundo andar. N�o � uma atra��o tur�stica muito agrad�vel. ', 'tumbleweed.png', NULL),
('3', 'O assassino da serra el�trica', 'Por toda a �rea de Red County, em San Andreas, no in�cio da d�cada de 1990 foram registradas ocorr�ncias de alguns assassinatos peculiares. Alguns cad�veres apareceram pela �rea, os motivos das mortes eram bem diversos, algumas foram causadas por ferramentas como p�s e martelos, mas outras eram mais incomuns, causadas por ferimentos que pareciam ser criados por uma serra el�trica. V�rios corpos foram descobertos enterrados por Red County, o que, na �poca, gerou boatos de um assassino em s�rie. Pesquisas indicam que o assassino era uma mulher que viveu na �rea rural de San Andreas na �poca das mortes chamada Catalina Vialpando, a principal prova s�o covas com cad�veres cavadas na parte exterior de uma cabana localizada em Fern Ridge, local no qual morou por anos. Catalina morreu em 2001, em um suspeito acidente de helic�ptero, que parecia ter conex�es com o cartel colombiano, que ocorreu em Cochrane Dam, uma barragem localizada em Shoreside Vale, em Liberty City. ', 'serraeletrica.png', NULL),
('3', 'Os g�ngsters fantasmas', 'Um mist�rio muito estranho e sem resolu��o acorre todas as noites no Cemit�rio de Vinewood, em Vinewood Boulevard, Los Santos. Sempre que o Sol se p�e, estranhas picha��es de gangues aparecem no muro que cerca o cemit�rio e desaparecem pela manh�. O fen�meno acontece desde 1991, j� foi analisado e simplesmente n�o h� uma resposta concreta. N�o h� res�duos de nenhuma tinta especial nas paredes ou algo similar. Boatos dizem que s�o manifesta��es dos fantasmas de g�ngsters que morreram em guerras de gangues na d�cada de 1990. ', 'gangsters.png', 'gangsters2.png'),
('3', 'Las Brujas', 'Em um caso parecido com Tumbleweed, temos outra cidade do velho oeste abandonada que parece ser assombrada. Las Brujas � uma vila do deserto de Bone County, San Andreas. Visitantes afirmam que, ao entrar na cidade durante a noite, podem ser ouvidos sussurros, passos, gritos e at� cavalos, mas o mais assustador � que Las Brujas fica situada no meio de c�nions, o que a deixa isolada de qualquer tipo de civiliza��o, ou seja, n�o h� nenhuma alma por perto. Apari��es de fantasmas tamb�m s�o recorrentes aqui, principalmente no cemit�rio. Las Brujas foi palco de muitos assassinatos de povos mexicanos por parte de ind�genas, esses povos habitavam a vila e n�o eram bem recebidos pelos nativos.  ', 'lasbrujas.png', 'lasbrujas2.png')
GO

INSERT INTO tipoHistoria (idHistoria, idTipo) 
VALUES
('1', '1'),
('2', '2'),
('3', '2'),
('4', '2'),
('5', '2'),
('6', '2'),
('7', '3'),
('7', '6'),
('8', '4'),
('8', '6'),
('9', '4'),
('9', '5'),
('10', '3'),
('10', '6'),
('11', '7'),
('12', '3'),
('12', '4'),
('13', '4'),
('13', '4'),
('13', '6'),
('13', '8'),
('14', '3'),
('14', '4'),
('14', '6'),
('15', '3'),
('15', '4');
GO

INSERT INTO regiaoHistoria (idHistoria, idRegiao) 
VALUES
('1', '1'),
('2', '2'),
('3', '3'),
('4', '1'),
('5', '1'),
('6', '4'),
('6', '9'),
('6', '10'),
('6', '11'),
('7', '4'),
('7', '6'),
('8', '4'),
('9', '4'),
('9', '14'),
('10', '4'),
('10', '11'),
('11', '4'),
('11', '6'),
('11', '9'),
('11', '11'),
('11', '14'),
('12', '2'),
('13', '4'),
('13', '12'),
('14', '4'),
('14', '5'),
('15', '4'),
('15', '14');
GO