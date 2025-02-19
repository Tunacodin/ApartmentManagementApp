UPDATE CardInfos SET BankName = CASE WHEN CardNumber LIKE '4%' THEN 'Yapı Kredi' WHEN CardNumber LIKE '5%' THEN 'Garanti' WHEN CardNumber LIKE '9%' THEN 'Ziraat' ELSE 'Diğer' END, BankLogoUrl = CASE WHEN CardNumber LIKE '4%' THEN 'https://storage.googleapis.com/apartment-management/bank-logos/yapikredi.png' WHEN CardNumber LIKE '5%' THEN 'https://storage.googleapis.com/apartment-management/bank-logos/garanti.png' WHEN CardNumber LIKE '9%' THEN 'https://storage.googleapis.com/apartment-management/bank-logos/ziraat.png' ELSE 'https://storage.googleapis.com/apartment-management/bank-logos/default.png' END WHERE BankName = '' OR BankLogoUrl = '';
