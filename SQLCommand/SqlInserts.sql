USE TicketSale

SELECT * FROM Cities
SELECT * FROM States
/////DELETE FROM States

INSERT INTO States (AcronymState, StateName, CreatedAt)
VALUES 
('AC', 'Acre', GETDATE()),
('AL', 'Alagoas', GETDATE()),
('AP', 'Amapá', GETDATE()),
('AM', 'Amazonas', GETDATE()),
('BA', 'Bahia', GETDATE()),
('CE', 'Ceará', GETDATE()),
('DF', 'Distrito Federal', GETDATE()),
('ES', 'Espírito Santo', GETDATE()),
('GO', 'Goiás', GETDATE()),
('MA', 'Maranhão', GETDATE()),
('MT', 'Mato Grosso', GETDATE()),
('MS', 'Mato Grosso do Sul', GETDATE()),
('MG', 'Minas Gerais', GETDATE()),
('PA', 'Pará', GETDATE()),
('PB', 'Paraíba', GETDATE()),
('PR', 'Paraná', GETDATE()),
('PE', 'Pernambuco', GETDATE()),
('PI', 'Piauí', GETDATE()),
('RJ', 'Rio de Janeiro', GETDATE()),
('RN', 'Rio Grande do Norte', GETDATE()),
('RS', 'Rio Grande do Sul', GETDATE()),
('RO', 'Rondônia', GETDATE()),
('RR', 'Roraima', GETDATE()),
('SC', 'Santa Catarina', GETDATE()),
('SP', 'São Paulo', GETDATE()),
('SE', 'Sergipe', GETDATE()),
('TO', 'Tocantins', GETDATE());


INSERT INTO Cities (StateId, CityName, CreatedAt)
VALUES
(29, 'Rio Branco',GETDATE()),
(30, 'Maceió',GETDATE()),
(31, 'Macapá',GETDATE()),
(32, 'Manaus',GETDATE()),
(33, 'Salvador',GETDATE()),
(34, 'Fortaleza',GETDATE()),
(35, 'Brasília',GETDATE()),
(36, 'Vitória',GETDATE()),
(37, 'Goiânia',GETDATE()),
(38, 'São Luís',GETDATE()),
(39, 'Cuiabá',GETDATE()),
(40, 'Campo Grande',GETDATE()),
(41, 'Belo Horizonte',GETDATE()),
(42, 'Belém',GETDATE()),
(43, 'João Pessoa',GETDATE()),
(44, 'Curitiba',GETDATE()),
(45, 'Recife',GETDATE()),
(46, 'Teresina',GETDATE()),
(47, 'Rio de Janeiro',GETDATE()),
(48, 'Natal',GETDATE()),
(49, 'Porto Alegre',GETDATE()),
(50, 'Porto Velho',GETDATE()),
(51, 'Boa Vista',GETDATE()),
(52, 'Florianópolis',GETDATE()),
(53, 'São Paulo',GETDATE()),
(54, 'Aracaju',GETDATE()),
(55, 'Palmas',GETDATE());
