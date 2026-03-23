--11
SELECT *
FROM users
WHERE EXISTS(
	SELECT *
    FROM views
    WHERE views.user_id = users.user_id
);

--12
SELECT * 
FROM channels
WHERE EXISTS(
	SELECT 1
    FROM videos
    WHERE videos.channel_id = channels.channel_id
)

--13
SELECT * 
FROM videos
WHERE EXISTS(
	SELECT 1
    FROM comments
    WHERE comments.video_id = videos.video_id
)

--14
SELECT *
FROM users
WHERE EXISTS(
	SELECT 1
    FROM likes
    WHERE users.user_id = likes.user_id
)

--16
SELECT *
FROM users
WHERE NOT EXISTS(
	SELECT 1
    FROM views
    WHERE views.user_id = users.user_id
)

--17
SELECT *
FROM channels
WHERE NOT EXISTS(
    SELECT *
    FROM videos
    WHERE videos.channel_id = channels.channel_id
    )

--18
SELECT *
FROM videos
WHERE NOT EXISTS(
    SELECT *
    FROM comments
    WHERE videos.video_id = comments.video_id
    )

--21
SELECT *
FROM videos AS v1
WHERE v1.duration_sec > ANY(
    SELECT v2.duration_sec
    FROM videos AS v2
    WHERE v2.channel_id IN (
        SELECT channels.channel_id
        FROM channels
        WHERE channels.channel_name = "lateNightLoot"
        )
    );

--22
--EZ NEM JÓ
SELECT *, COUNT(views.user_id)as osszeg
FROM users AS u1 
INNER JOIN views ON views.user_id = u1.user_id
GROUP BY views.user_id
HAVING osszeg > 0
WHERE osszeg > ANY(
 	   SELECT COUNT(views.user_id)as 				osszeg2
		FROM users AS u2 
		INNER JOIN views ON views.user_id = 		u2.user_id
		GROUP BY views.user_id
		HAVING osszeg2 < osszeg
    	AND WHERE u2.birth_year < 2015
)