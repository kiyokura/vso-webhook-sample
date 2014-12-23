using System;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace VsoWebHookSample.Controllers
{
public class GitController : Controller
{
  [HttpPost]
  public HttpResponseMessage CodePushed(Rootobject content)
  {
    // 実際はcontentの中身をつかってやりたいことをやる！

    return new HttpResponseMessage(HttpStatusCode.OK);
  }
}


  public class Rootobject
  {
    public string id { get; set; }
    public string eventType { get; set; }
    public string publisherId { get; set; }
    public Message message { get; set; }
    public Detailedmessage detailedMessage { get; set; }
    public Resource resource { get; set; }
    public string resourceVersion { get; set; }
    public Resourcecontainers resourceContainers { get; set; }
    public DateTime createdDate { get; set; }
  }

  public class Message
  {
    public string text { get; set; }
    public string html { get; set; }
    public string markdown { get; set; }
  }

  public class Detailedmessage
  {
    public string text { get; set; }
    public string html { get; set; }
    public string markdown { get; set; }
  }

  public class Resource
  {
    public Refupdate[] refUpdates { get; set; }
    public Repository repository { get; set; }
    public Pushedby pushedBy { get; set; }
    public int pushId { get; set; }
    public DateTime date { get; set; }
    public string url { get; set; }
  }

  public class Repository
  {
    public string id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public Project project { get; set; }
    public string defaultBranch { get; set; }
    public string remoteUrl { get; set; }
  }

  public class Project
  {
    public string id { get; set; }
    public string name { get; set; }
    public string url { get; set; }
    public string state { get; set; }
  }

  public class Pushedby
  {
    public string id { get; set; }
    public string displayName { get; set; }
    public string uniqueName { get; set; }
  }

  public class Refupdate
  {
    public string name { get; set; }
    public string oldObjectId { get; set; }
    public string newObjectId { get; set; }
  }

  public class Resourcecontainers
  {
    public Collection collection { get; set; }
    public Account account { get; set; }
    public Project1 project { get; set; }
  }

  public class Collection
  {
    public string id { get; set; }
  }

  public class Account
  {
    public string id { get; set; }
  }

  public class Project1
  {
    public string id { get; set; }
  }



}