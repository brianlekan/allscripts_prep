configs ={
  :git => {
    :remotes => potentially_change("remotes",__FILE__),
    :repo => "allscripts_prep"
  }
}
configatron.configure_from_hash(configs)
