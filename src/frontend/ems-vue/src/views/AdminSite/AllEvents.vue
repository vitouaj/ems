<template>
    <div>
        <v-row>
            <p class="font-weight-bold">All Events</p>
        </v-row>
        <!-- Event List -->
        <v-row>
            <v-col cols="3">
                <event-card/>
            </v-col>
            <v-col cols="3">
                <event-card/>
            </v-col>
            <v-col cols="3">
                <event-card/>
            </v-col>
            <v-col cols="3">
                <event-card/>
            </v-col>
            <v-col cols="3">
                <event-card/>
            </v-col>
            <v-col cols="3">
                <event-card/>
            </v-col>
            <v-col cols="3">
                <event-card/>
            </v-col>
            <v-col cols="3">
                <event-card/>
            </v-col>
        </v-row>
    </div>
</template> 

<script>
import EventCard from './components/EventCard.vue';
export default {
    components: {
        EventCard
    }
}
</script>