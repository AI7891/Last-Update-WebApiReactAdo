const dataTest = "test"


use (dataTest)
db.restaurant.find();

use("test");
db.restaurant.findOne();

use('test')
db.restaurant.insertMany([{

  "address": {
    "building": "2780",
    "coord": [
      -73.98241999999999,
      40.579505
    ],
    "street": "Stillwell Avenue",
    "zipcode": "11224"
  },
  "borough": "Brooklyn",
  "cuisine": "American ",
  "grades": [
    {
      // "date": {
      //   "$date": "2014-06-10T00:00:00Z"
      // }
      date: new Date("2014-06-10T00:00:00Z"),
      "grade": "A",
      "score": 5
    },
    {
      // "date": {
      //   "$date": "2013-06-05T00:00:00Z"
      // }
      date: new Date("2014-06-10T00:00:00Z"),
      "grade": "A",
      "score": 7
    },
    {
      // "date": {
      //   "$date": "2012-04-13T00:00:00Z"
      // }
      date: new Date("2014-06-10T00:00:00Z"),
      "grade" : "A",
      "score" : 12
    },
    {
      date: new Date("2014-06-10T00:00:00Z"),
      "grade": "A",
      "score": 12
    }
  ],
  "name": "Digital City",
  "restaurant_id": "77777777"
}])

use('test')
db.restaurant.find({
  name:/Queens/i
});










