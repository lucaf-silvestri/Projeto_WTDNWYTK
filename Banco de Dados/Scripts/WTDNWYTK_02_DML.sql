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
('Assombração'),
('Local Misterioso'),
('Cadáver'),
('Acontecimento Misterioso'),
('Alienígena'),
('Assassino em Série'),
('Impossível de Descrever');
GO

INSERT INTO regiao (nomeRegiao) 
VALUES
('Nuevo Paraíso'),
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
('1', 'A Máscara Asteca', 'A máscara asteca é um artefato místico amaldiçoado enterrado em uma catacumba localizada abaixo do abandonado palácio que pertenceu à Agustin Allende, em Escalera, Nuevo Paraíso, no México. A máscara, supostamente, se retirada de seu devido lugar, pode liberar sua maldição sobre os seres que vivem na região, assim, transformando-os em mortos-vivos, que perambulam em busca de carne para se alimentar. A maldição não afeta apenas humanos, mas também a maioria das espécies da fauna da região.', NULL, NULL),
('1', 'O Jackalope', 'O Jackalope é uma criatura avistada em áreas de New Austin, sua aparência é de um coelho com chifres. Seu comportamento é idêntico ao de um coelho comum. ', 'jackalope.png', NULL),
('1', 'Os Pé-Grandes de West Elizabeth', 'Teorias dizem que na floresta de Tall Trees, em West Elizabeth, vive uma família de pé-grandes. Supostamente, os serem vivem na região por milênios e se alimentam de pequenas frutas e cogumelos. Seus tamanhos variam de 2 a 3 metros de altura, seus corpos são cobertos de pelos e, apesar de tímidos, se mostram agressivos se ameaçados. Muitos caçadores locais afirmam já terem avistado as criaturas perambulando pela floresta, esses descreveram olhos grandes, uma sobrancelha pronunciada e uma testa grande e baixa; o topo da cabeça foi descrito como arredondado e com crista, semelhante à crista sagital do gorila macho. São comumente relatados como tendo um cheiro forte e desagradável por aqueles que afirmam tê-lo encontrado. Apesar de sua aparência, eles são muito semelhantes aos humanos em suas reações e sentimentos. ', 'pegrandeWE.png', NULL),
('1', 'O Chupacabra de Nuevo Paraíso', 'No território de Nuevo Paraíso, no México, foram relatadas diversas aparições da criatura conhecida como Chupacabra. Pouco se sabe sobre ela, com relatos indicando uma aparência semelhante à de um lobo ou puma. O Chupacabra, como mostra seu nome, costuma se alimentar de cabras, se disfarçando em seus rebanhos e atacando quando fica com fome, mordendo o pescoço dos animais e drenando seu sangue.', NULL, NULL),
('1', 'O Unicórnio de Nuevo Paraíso', 'Além do Chupacabra, o território de Nuevo paraíso também parece ser habitado por outra espécie incomum, o Unicórnio. A criatura cavalga pela região como um cavalo e se alimenta das pequenas vegetações do solo, mas é agressiva se ameaçada. Possui características muito parecidas com as de um cavalo, com a única diferença sendo um chifre em formato de cone no topo da cabeça e um rastro colorido que solta enquanto cavalga. As principais evidências de sua existência é um pó colorido desconhecido encontrado no solo da área (provavelmente proveniente do rastro colorido citado anteriormente) e animais caçadores mortos por um largo furo em seus corpos, provavelmente causado por ataques do chifre do unicórnio.', NULL, NULL),
('2', 'O Pé-Grande do Mount Chiliad', 'Pé-Grandes parecem ser bens comuns na América, o mito dessa vez é de certas aparições da criatura nas florestas na parte mais baixa do Monte Chiliad, montanha localizada a oeste de Whetstone,  na parte rural de San Andreas. Esse é, com certeza, o rumor mais forte da lista, sendo que toda a população que vive nas cidades próximas à montanha parece estar certa de que a criatura vive ou já viveu por lá. Suas aparições aconteceram em sua maioria entre os anos 1990 à 1992, principalmente vivenciadas por fazendeiros, campistas ou pessoas que faziam trilhas. Em uma cabana na área foram encontrados restos de animais mutilados, com ferimentos que pareciam ser causados por ursos, mas sem nenhum motivo aparente de o animal ter sido assassinado na parte interna da cabana, o que leva a pensar que é um comportamento do Pé-Grande. Ainda fica mais estranho com o fato de que o mesmo aconteceu em outra cabana, só que distante do local, mais especificamente em Shady Creeks, o que pode significar que o ser não vivia apenas na montanha, mas perambulava por todas as florestas próximas. Muitas pegadas não identificadas já foram encontradas no solo das regiões citadas. Muitos dizem que viram a criatura se movimentando por entre as árvores, os vigiando de longe. Alguns ainda relatam aparições até os dias atuais, mas sem provas concretas, o que leva a pensar que apenas tentam manter a lenda viva, já outros defendem a teoria de que a criatura morreu no ano de 1992, como nos anos seguintes houve uma quantidade de aparições significativamente menor. De uma forma ou de outra, a existência do Pé-Grande do Mount Chiliad nunca foi confirmada.', NULL, NULL),
('2', 'O Fantasma do Monte Gordo', 'Muitas testemunhas afirmam que, no topo do Monte Gordo, em Blaine County, San Andreas, pode ser avistado um fantasma flutuando sobre uma rocha. Um homem que fazia uma trilha na região durante a noite comentou que viu o fantasma e, logo abaixo, uma mancha de sangue que parecia conter algo escrito, mas que quando se aproximou, ambos o fantasma e o sangue não estavam mais lá. É especulado que esse seja o fantasma de Jolene Evans, que morreu no local enquanto caminhava com seu marido John "Jock" Cranley, quando uma briga acabou com Jolene caindo do penhasco. Muitos afirmam que Jock empurrou a esposa, mas o homem afirma que nunca o faria.', NULL, NULL),
('2', 'Pânico nas florestas de San Andreas', 'Por todo o estado de San Andreas, foram registrados relatos de pessoas que afirmam terem experienciado um fenômeno conhecido como "Pânico na Floresta". O fenômeno supostamente acontece com pessoas que passam tempo demais nas florestas do estado. Tudo começa com todos os sons da floresta cessando, após isso, começam a sentir paranoia, escutar um alto zumbido que não parece vir de lugar nenhum e avistar criaturas e sombras se movendo na vegetação, sempre com um constante sentimento de perigo iminente, mas todos os sintomas acabam ao retornar à civilização. Alguns afirmam que o fenômeno pode ser explicado pela manifestação do Deus Pagão Pan, protetor dos lugares selvagens, cuja presença inspira o terror. ', NULL, NULL),
('2', 'Os corpos de El Castillo del Diablo', 'Em 1992, foi encontrada por agentes do FBI uma pilha de corpos em sacos enterrada em El Castillo del Diablo, uma área situada no deserto de Bone County, em San Andreas. Foi confirmado pelo governo que os corpos pertencem a membros de diferentes familias mafiosas que atuavam em Las Venturas nas décadas de 1980 e 1990. Enterrar os corpos de seus inimigos no deserto de Bone County foi uma prática muito utilizada pelas famílias mafiosas da época. A parte bizarra sobre a descoberta é o fato de os agentes terem cavado um buraco de aproximadamente 4 metros de profundidade envolta dos sacos com os corpos e o deixado aberto durante meses, com os corpos à mostra. Poucas pessoas passavam pela região (principalmente pelo fato de estar próxima à área do governo conhecida como Área 69), mas algumas testemunhas afirmaram que viram o buraco com os corpos na época. Algumas pessoas especulam que os corpos não possuem conexões com a máfia e seriam algum tipo de experimento dos agentes da Área 69 e teriam até relação com alienígenas, mas nada disso foi confirmado. Hoje em dia o buraco já foi fechado. ', 'corposECDD.png', NULL),
('2', 'Os carros fantasmas de Back O Beyond', 'Mais um mistério das florestas de Whetstone e Flint County, dessa vez, carros fantasmas. Há uma lenda de um carro do modelo Benefactor Glendale 1991 que dirige sozinho pela floresta em Back O Beyond durante a madrugada. Algumas pessoas afirmam que viram o veículo se movendo e logo parando e, quando se aproximaram, perceberam que não havia motorista. Os relatos informam que o carro já foi visto em diversas cores, mas sempre do mesmo modelo e com partes quebradas ou faltando. Não existe teorias a respeito da origem do acontecimento. A imagem a seguir foi fotografada por uma testemunha do fenômeno. ', 'carrosfantasma.png', NULL),
('3', 'OVNI´s e Alienígenas em San Andreas', 'Desde a década de 1980 são relatadas aparições de OVNI´s e manifestações alienígenas em geral na área de San Andreas. O local que possui aparições mais recorrentes é o deserto de Bone County, à leste de Las Venturas. UFO´s são os mais relatados, supostamente aparecendo em toda a parte rural do estado, de desertos a florestas. Diversos pilotos de veículos aéreos dizem já terem visto os UFO´s voando em grandes alturas, alguns dizem ter visto lasers, luzes, armas e até mesmo os próprios alienígenas. Há relatos de luzes também em terra, como em um caso que envolve um grupo de hippies que acampava em uma área no Deserto de Grand Senora que dizem ter visto as luzes enquanto fritavam hambúrgueres durante a noite. Muitos afirmam que existe uma ligação entre o Mistério do Mural do Monte Chiliad e alienígenas pelo fato de existirem desenhos que representam discos voadores espalhados pela montanha, além de rumores que dizem que existe um UFO no topo da montanha que fica invisível durante o dia, esses rumores são apoiados por falas de pessoas que dizem ter escutado sons estranhos enquanto faziam trilhas pelo monte. Existem diversas imagens pela internet de supostos mapas que pertencem ao governo e mostram localizações do estado em que as naves alienígenas podem ser avistadas. Rumores também acusam o governo dos EUA de fazerem experimentos com seres e artefatos alienígenas em suas bases militares, mais especificamente, a Área 69, durante a década de 1990 e o Fort Zancudo, mais recentemente, de 2010 até hoje em dia. Algumas pessoas e grupos chegam a se reunir no estado de San Andreas para “caçar” os alienígenas e desvendar esse mistério, outras duvidam que os seres existam. Em 1997, um fazendeiro de Flint County informou aos jornais que extraterrestres criaram símbolos em sua plantação de milho como uma forma de comunicação, um tempo depois, confessou que ele mesmo havia criado os padrões no milho com seu trator para chamar a atenção da mídia. É incerta a existência desses seres, mas esse mistério, juntamente com o Pé-Grande do Mount Chiliad, é um dos mais comentados pela população. ', 'ufo.png', 'ufo2.png'),
('3', 'A cidade mal-assombrada de Tumbleweed', 'Há relatos de diversas testemunhas que afirmam que presenciaram atividades paranormais e aparições de fantasmas na cidade conhecida como Tumbleweed, localizada em Gaptooth Ridge, no estado de New Austin. Essa foi uma das primeiras cidades da região no início do século XX, e suas construções ainda estão de pé até os dias de hoje, pelo fato de não ser uma área apropriada para a construção de uma cidade moderna, ou simplesmente pelo medo da população a respeito de suas lendas. A cidade foi abandonada no início do século passado, com a construção da estrada para Armadillo,  outra cidade mais desenvolvida, o que causou o deslocamento da população de Tubleweed para lá. Após a desocupação da área, Tumbleweed foi utilizada como esconderijo para criminosos após o fim do período do velho-oeste, consequentemente, foi palco de diversos crimes, como estupros e enforcamentos por parte dos fora-da-lei. Teorias afirmam que essa é a razão de ser um local mal-assombrado, e que as almas das pessoas assassinadas ali permanecem na área até hoje. As testemunhas das assombrações afirmam que, ao entrar na área, é possível escutar sussurros, latidos de cachorros, sons de carroças, entre outros barulhos, mesmo sem haver ninguém ali, como se ainda fosse uma cidade habitada por uma população. Alguns dizem que, ao dirigir dentro da cidade, o motor do veículo para de funcionar. Podem ser ouvidos barulhos de algemas na delegacia e a música do piano no salão. Mas os locais mais assustadores são, com certeza, a igreja e a mansão, localizada no topo da colina mais alta da cidade. A igreja possui seu cemitério, onde mais são relatadas as atividades paranormais, e dentro da capela já foram testemunhadas aparições de fantasmas de pessoas andando do lado de dentro, vistas pelas janelas, e até de demônios. Já para quem é corajoso o suficiente para entrar na mansão, são experienciados objetos se movendo ou quebrando sozinhos, sons de gritos e passos, um frio sem explicação, entre outros eventos. Quem entra diz que experienciou uma má sensação constante, além de se sentirem observados. Quem olha para a mansão de uma certa distância, pode avistar figuras fantasmagóricas de pessoas nas janelas do segundo andar. Não é uma atração turística muito agradável. ', 'tumbleweed.png', NULL),
('3', 'O assassino da serra elétrica', 'Por toda a área de Red County, em San Andreas, no início da década de 1990 foram registradas ocorrências de alguns assassinatos peculiares. Alguns cadáveres apareceram pela área, os motivos das mortes eram bem diversos, algumas foram causadas por ferramentas como pás e martelos, mas outras eram mais incomuns, causadas por ferimentos que pareciam ser criados por uma serra elétrica. Vários corpos foram descobertos enterrados por Red County, o que, na época, gerou boatos de um assassino em série. Pesquisas indicam que o assassino era uma mulher que viveu na área rural de San Andreas na época das mortes chamada Catalina Vialpando, a principal prova são covas com cadáveres cavadas na parte exterior de uma cabana localizada em Fern Ridge, local no qual morou por anos. Catalina morreu em 2001, em um suspeito acidente de helicóptero, que parecia ter conexões com o cartel colombiano, que ocorreu em Cochrane Dam, uma barragem localizada em Shoreside Vale, em Liberty City. ', 'serraeletrica.png', NULL),
('3', 'Os gângsters fantasmas', 'Um mistério muito estranho e sem resolução acorre todas as noites no Cemitério de Vinewood, em Vinewood Boulevard, Los Santos. Sempre que o Sol se põe, estranhas pichações de gangues aparecem no muro que cerca o cemitério e desaparecem pela manhã. O fenômeno acontece desde 1991, já foi analisado e simplesmente não há uma resposta concreta. Não há resíduos de nenhuma tinta especial nas paredes ou algo similar. Boatos dizem que são manifestações dos fantasmas de gângsters que morreram em guerras de gangues na década de 1990. ', 'gangsters.png', 'gangsters2.png'),
('3', 'Las Brujas', 'Em um caso parecido com Tumbleweed, temos outra cidade do velho oeste abandonada que parece ser assombrada. Las Brujas é uma vila do deserto de Bone County, San Andreas. Visitantes afirmam que, ao entrar na cidade durante a noite, podem ser ouvidos sussurros, passos, gritos e até cavalos, mas o mais assustador é que Las Brujas fica situada no meio de cânions, o que a deixa isolada de qualquer tipo de civilização, ou seja, não há nenhuma alma por perto. Aparições de fantasmas também são recorrentes aqui, principalmente no cemitério. Las Brujas foi palco de muitos assassinatos de povos mexicanos por parte de indígenas, esses povos habitavam a vila e não eram bem recebidos pelos nativos.  ', 'lasbrujas.png', 'lasbrujas2.png')
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