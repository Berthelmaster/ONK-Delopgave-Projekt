<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Read HaandVaerker</h3>
                    <li v-for="post in posts" :key="post">{{post}}</li>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Read Vaerkstoejskasse</h3>
                    <li v-for="todo in todos" :key="todo">{{todo}}</li>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Read HaandVaerker</h3>
                </div>
        </v-row>
    </v-container>
</template>


<script>
import axios from 'axios';


export default {
    data() {
        return {
            posts: [],
            todos: []
            }
    },  

created() {
    axios.get('https://localhost:44339/api/Haandvaerkers')
    .then(reponse => {
        this.posts = reponse.data
    })
    
 },
 
}
</script>