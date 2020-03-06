<template>
    <v-container>
        <v-row class="text-center">
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete HaandVaerker</h3>
                    <li v-for="post of posts" v-bind:key="post">
                        <p>{{post.id}}</p>
                    </li>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete Vaerkstoejskasse</h3>
                </div>
                <div style="width: 30%; margin: 1.66%">
                    <h3 class="headline">Delete HaandVaerker</h3>
                </div>
        </v-row>
    </v-container>
</template>

<script>
import axios from 'axios';

export default {
    data() {
        return {
            posts: []
            }
    },  

created() {
    axios.get('http://jsonplaceholder.typicode.com/posts')
    .then(reponse => {
        this.posts = reponse.data
    })}}
</script>