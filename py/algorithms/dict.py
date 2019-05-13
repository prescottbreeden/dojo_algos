people = [
    {
    "first_name": "Bob",
    "last_name": "Ross",
    "email": "bob@gmail.com",
    "pets": [
        {
            "name": "Nick Furry",
            "species": "cat",
            "color": "orange",
            "friendly": True,
            "age": 8,
            "favorite_activities": [
                {
                    "activity": "Sleeping",
                    "location": "Human lap"
                },
                {
                    "activity": "Eating",
                    "location": "Kitchen Counter"
                }
            ]
        }
    ]
}
]

print(people[0]["pets"][0]["name"])
# print all people names
# print all pets belonging to Bob Ross
# print all cats 
# isFriendly(person, pet_name) => true or false