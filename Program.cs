using System.Text.Json;

var json = File.ReadAllText("data.json");
var posts = new List<Post>(JsonSerializer.Deserialize<List<Post>>(json));
Console.WriteLine(posts[0].Title);

// var posts = new List<Post>(){
//     new(){Id=1,UserId=1,Title="html etiketleri",Body="head,body,div,p,br,"},
//     new (){Id=2,UserId=1,Title="unity'de hareket sistemi",Body="cc.Move(velocity * Time.deltaTime);"},
//     new (){Id=3,UserId=2,Title="fl studioda orkestral müzik",Body="OT strings si-do#-re-do#"}
// };

// File.WriteAllText("test.json",JsonSerializer.Serialize(posts,new JsonSerializerOptions(){WriteIndented=true}));

class Post{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
}