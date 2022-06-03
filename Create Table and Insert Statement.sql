/*Create Table 
CREATE TABLE Suppliers (
    id int PRIMARY KEY identity,
    code int NULL,
    supplierName varchar(500) NULL,
	telephoneNumber varchar(50) null
);

/* Insert Data into DB *
INSERT INTO Suppliers(code, supplierName, telephoneNumber) 
VALUES
(234, 'Eskom Holdings Limited', '0860037566'),
(939, 'Focus Rooms (Pty) Ltd', '0820776910'),
(34, 'GSM Electro', '0128110069'),
(1264, 'Jody and Herman Investments CC', '0118864227'),
(5667, 'Johan Le Roux Ingenieurswerke', '0233423390'),
(667, 'L. J. Ross t/a Petite Cafe', '0117868101'),
(45, 'L.A Auto Center  CC t/a LA Body Works', '0219488412'),
(1351, 'LG Tow-In CC', '0828044026'),
(1352, 'LM Greyling t/aThe Electric Advertiser', '0119545972'),
(1437, 'M.H Cloete Enterprises (Pty) Ltd  t/a  Rola Motors', '0218418300'),
(67, 'M.M Hydraulics CC', '0114256578'),
(1980, 'Phulo Human Capital (Pty) Ltd', '0114755934'),
(345, 'Picaro 115 CC t/a H2O CT Services', '0216745710'),
(2279, 'Safetygrip CC', '0117086660'),
(876, 'Safic (Pty) Ltd', '0114064000'),
(2549, 'The Financial Planning Institute Of Southern Africa', '0861000374'),
(935, 'The Fitment Zone  CC', '0118234181'),
(2693, 'Turnweld Engineering CC', '0115468790'),
(6, 'Tutuka Motor Holdings Pty Ltd t/a Tutuka Motor Lab', '0117044324'),
(134, 'WP Exhaust Brake & Clutch t/a In Focus Fleet Services', '0219055028'),
(3277, 'WP Sekuriteit', '0233421732'),
(53, 'Brietta Trading (Pty) Ltd', '0115526000'),
(392, 'C.N. Braam t/a CNB Electrical Services', '0832835399'),
(625, 'Creative Crew (Pty) Ltd', '0120040218')