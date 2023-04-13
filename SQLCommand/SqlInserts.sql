USE TicketSale

SELECT * FROM Cities
SELECT * FROM States
/////DELETE FROM States

INSERT INTO States (AcronymState, StateName, CreatedAt)
VALUES 
('AC', 'Acre', GETDATE()),
('AL', 'Alagoas', GETDATE()),
('AP', 'Amap�', GETDATE()),
('AM', 'Amazonas', GETDATE()),
('BA', 'Bahia', GETDATE()),
('CE', 'Cear�', GETDATE()),
('DF', 'Distrito Federal', GETDATE()),
('ES', 'Esp�rito Santo', GETDATE()),
('GO', 'Goi�s', GETDATE()),
('MA', 'Maranh�o', GETDATE()),
('MT', 'Mato Grosso', GETDATE()),
('MS', 'Mato Grosso do Sul', GETDATE()),
('MG', 'Minas Gerais', GETDATE()),
('PA', 'Par�', GETDATE()),
('PB', 'Para�ba', GETDATE()),
('PR', 'Paran�', GETDATE()),
('PE', 'Pernambuco', GETDATE()),
('PI', 'Piau�', GETDATE()),
('RJ', 'Rio de Janeiro', GETDATE()),
('RN', 'Rio Grande do Norte', GETDATE()),
('RS', 'Rio Grande do Sul', GETDATE()),
('RO', 'Rond�nia', GETDATE()),
('RR', 'Roraima', GETDATE()),
('SC', 'Santa Catarina', GETDATE()),
('SP', 'S�o Paulo', GETDATE()),
('SE', 'Sergipe', GETDATE()),
('TO', 'Tocantins', GETDATE());


INSERT INTO Cities (StateId, CityName, CreatedAt)
VALUES
(29, 'Rio Branco',GETDATE()),
(30, 'Macei�',GETDATE()),
(31, 'Macap�',GETDATE()),
(32, 'Manaus',GETDATE()),
(33, 'Salvador',GETDATE()),
(34, 'Fortaleza',GETDATE()),
(35, 'Bras�lia',GETDATE()),
(36, 'Vit�ria',GETDATE()),
(37, 'Goi�nia',GETDATE()),
(38, 'S�o Lu�s',GETDATE()),
(39, 'Cuiab�',GETDATE()),
(40, 'Campo Grande',GETDATE()),
(41, 'Belo Horizonte',GETDATE()),
(42, 'Bel�m',GETDATE()),
(43, 'Jo�o Pessoa',GETDATE()),
(44, 'Curitiba',GETDATE()),
(45, 'Recife',GETDATE()),
(46, 'Teresina',GETDATE()),
(47, 'Rio de Janeiro',GETDATE()),
(48, 'Natal',GETDATE()),
(49, 'Porto Alegre',GETDATE()),
(50, 'Porto Velho',GETDATE()),
(51, 'Boa Vista',GETDATE()),
(52, 'Florian�polis',GETDATE()),
(53, 'S�o Paulo',GETDATE()),
(54, 'Aracaju',GETDATE()),
(55, 'Palmas',GETDATE());
