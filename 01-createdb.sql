USE TheTrackingFellowship;

CREATE TABLE user
(
 user_id serial PRIMARY KEY,
 username VARCHAR ( 50 ) UNIQUE NOT NULL,
 password VARCHAR ( 100 ) NOT NULL,
 email VARCHAR ( 255 ) UNIQUE NOT NULL,
 created_on TIMESTAMP NOT NULL,
 last_login TIMESTAMP
);


create table TheTrackingFellowship.gamertag
(
    gamertag_id bigint unsigned auto_increment
        primary key,
    tag         varchar(50)                                             not null,
    user_key    bigint unsigned                                         null,
    game        enum ('LeagueOfLegends', 'Valorant', 'TeamfightTactics') not null,
    constraint gamertag_id
        unique (gamertag_id),
    constraint tag
        unique (tag),
    constraint gamertag_ibfk_1
        foreign key (user_key) references
TheTrackingFellowship.user (user_id)
            on delete cascade
);

create index user_key
    on TheTrackingFellowship.gamertag (user_key);