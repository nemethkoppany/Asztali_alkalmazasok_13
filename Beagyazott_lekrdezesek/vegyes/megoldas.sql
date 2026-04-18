-- 1
SELECT pc.modell,pc.ar
FROM pc
WHERE pc.ar IN (
    SELECT laptop.ar 
    from laptop
);

--2
SELECT stúdió.név
FROM stúdió 
WHERE stúdió.név IN (
	SELECT filmek.stúdióNév
	FROM filmek
	WHERE filmek.műfaj = 'sci-fi'
);

--Ugyan ez joinnal
SELECT stúdió.név
FROM stúdió 
INNER JOIN filmek ON filmek.stúdióNév = stúdió.név
WHERE filmek.műfaj = "sci-fi";

--3
SELECT kimenetelek.hajonev
FROM kimenetelek
WHERE kimenetelek.csatanev IN(
    SELECT csatak.csatanev
	FROM csatak
	WHERE RIGHT(csatak.datum,2) >= 43
    );

--4
SELECT filmszínész.név
FROM filmszínész
WHERE filmszínész.név IS NOT NULL 
AND filmszínész.név NOT IN(
	SELECT szerepelbenne.színészNév
	from szerepelbenne
);

--5
SELECT DISTINCT termek.gyarto 
FROM termek
WHERE termek.modell NOT IN (
	SELECT nyomtato.modell
	FROM nyomtato
	WHERE nyomtato.ar IN(
		SELECT laptop.ar
		FROM laptop
	)
);

--6
SELECT DISTINCT hajok.osztaly
FROM hajok
WHERE hajok.hajonev NOT IN(
	SELECT kimenetelek.hajonev
    FROM kimenetelek
);

--7
/*
SELECT termek.gyarto
FROM termek
WHERE termek.modell

SELECT termek.gyarto, COUNT(*) AS Darab
FROM termek
WHERE termek.tipus = "pc"
GROUP BY termek.gyarto
HAVING Darab >= 2

SELECT pc1.modell,pc1.ar
FROM pc AS pc1
WHERE EXISTS(
	SELECT 1
    FROM pc AS pc2
    WHERE pc1.ar = pc2.ar
    AND pc1.modell <> pc2.modell
)
ORDER BY pc1.ar
*/

--8
SELECT filmek.filmcím, filmek.év
FROM filmek
WHERE EXISTS(
	SELECT 1
    FROM szerepelbenne
    WHERE szerepelbenne.filmCím = filmek.filmcím
    AND szerepelbenne.filmÉv = filmek.év
	);

--9
SELECT hajok.hajonev
FROM hajok
WHERE EXISTS(
	SELECT 1
    FROM csatak 
    WHERE csatak.csatanev IN (
    	SELECT kimenetelek.csatanev
        FROM kimenetelek
        WHERE kimenetelek.eredmeny = "elsüllyedt"
    	AND kimenetelek.hajonev = hajok.hajonev 
    )
)