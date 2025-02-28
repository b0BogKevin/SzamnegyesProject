<script setup>
import { ref } from 'vue';
const szamok = ref("")
const lekert = ref()
const kuldes = async()=>{
  await fetch("https://localhost:7238/api",{
    method:"POST",
    body:"[" +szamok.value + "]",
    headers:{
      "Content-type":"application/json; charset=UTF-8"
    }
  })
   
}
const keres = async()=>{
    await fetch("https://localhost:7238/api")
    .then(resp=>resp.json())
    .then(data=>lekert.value=data)
}
</script>

<template>
  <h1>Számnégyes</h1>
  <input type="text" placeholder="0,0,0,0" v-model="szamok">
  <button v-on:click="kuldes">Küldés</button>
<br>
<h2>Lekérdezés</h2>
  <button v-on:click="keres()">lekérdezés</button>
  <div v-for="i in lekert">
    {{ i.szamok }} <br>
  </div>
</template>

