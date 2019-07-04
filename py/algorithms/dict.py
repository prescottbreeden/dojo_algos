people = [
    {
    "name": "Bob Ross",
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
                    "activity": "Watching TV",
                    "location": "Sofa"
                }
            ]
        }
    ]
}
]

if __name__ == "__main__":
    print(people[0]["pets"][0]["name"])
    # print all people names
    # print all pets belonging to Bob Ross
    # addPet(person, pet)
    # isFriendly(person, pet_name) => true or false
