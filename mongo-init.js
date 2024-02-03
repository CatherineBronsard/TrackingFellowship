db.createUser(
    {
        user: "admin",
        pwd: "pwd",
        roles: [
            {
                role: "readWrite",
                db: "TheTrackingFellowship"
            }
        ]
    }
);

db.createCollection("PlayerAccount")
db.createCollection("TFTMatches")
db.createCollection("LoLMatches")
